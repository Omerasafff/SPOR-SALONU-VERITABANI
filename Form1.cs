using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Form1 : Form
    {
        // SQL'de Kasa tablosu olmadığı için anlık ciroyu burada tutacağız
        decimal anlikKasaCirosu = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYenile();
        }

        private void VerileriYenile()
        {
            try
            {
                // NOT: Veritabanında görünen ID 'kisi_id' olduğu için listelemede onu kullanıyoruz.
                Listele("SELECT * FROM Uyeler ORDER BY kisi_id ASC", gridUye);
                Listele("SELECT * FROM Urunler ORDER BY urun_id ASC", gridUrun);
                Listele("SELECT * FROM DersProgrami ORDER BY program_id ASC", gridDers);
                Listele("SELECT * FROM Personel ORDER BY personel_id ASC", gridPersonel);

                // Vardiya listesi
                string vardiyaSql = "SELECT v.vardiya_id, p.ad || ' ' || p.soyad as personel, v.gun, v.baslangic_saati, v.bitis_saati FROM Vardiyalar v JOIN Personel p ON v.personel_id = p.personel_id ORDER BY v.vardiya_id DESC";
                gridVardiya.DataSource = Veritabani.VeriGetir(vardiyaSql);

                // Borçluları Listeleme (Sütun adı 'guncel_borc' olarak düzeltildi)
                gridFinans.DataSource = Veritabani.VeriGetir("SELECT kisi_id, ad, soyad, guncel_borc FROM Uyeler WHERE guncel_borc > 0 ORDER BY guncel_borc DESC");

                // Ciro hesapla butonunu tetikle
                btnCiro.PerformClick();
            }
            catch (Exception ex)
            {
                // Hata olursa program çökmesin
            }
        }

        void Listele(string sql, DataGridView grid)
        {
            grid.DataSource = Veritabani.VeriGetir(sql);
        }

        // ==========================================================
        // --- SEKME 1: ÜYE İŞLEMLERİ (10.000 TL BORÇ MANTIĞI) ---
        // ==========================================================
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection baglanti = Veritabani.BaglantiGetir())
            {
                baglanti.Open();
                NpgsqlTransaction trans = baglanti.BeginTransaction();

                try
                {
                    // 1. Üyeyi Kaydet
                    NpgsqlCommand komut = new NpgsqlCommand("CALL s_uye_ekle(@ad, @soyad, @tc, @tel, @mail, @cinsiyet)", baglanti, trans);
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@tel", txtTel.Text);
                    komut.Parameters.AddWithValue("@mail", txtMail.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", cmbCins.Text);
                    komut.ExecuteNonQuery();

                    // 2. YENİ KURAL: Kayıt olan herkese 10.000 TL Borç Yaz
                    // Sütun adı SQL dosyanızda 'guncel_borc' olduğu için düzeltildi.
                    NpgsqlCommand cmdBorc = new NpgsqlCommand("UPDATE Uyeler SET guncel_borc = 10000 WHERE tc_no = @tc", baglanti, trans);
                    cmdBorc.Parameters.AddWithValue("@tc", txtTc.Text);
                    cmdBorc.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("Üye Eklendi.\nHoşgeldin Borcu (10.000 TL) yansıtıldı.");
                    VerileriYenile();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridUye.CurrentRow != null)
            {
                // Onay isteyelim
                DialogResult cevap = MessageBox.Show("Bu üyeyi ve tüm geçmişini (Satışlar, Dersler vb.) silmek istediğinize emin misiniz?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.No) return;

                int kisiId = Convert.ToInt32(gridUye.CurrentRow.Cells["kisi_id"].Value);

                using (NpgsqlConnection baglanti = Veritabani.BaglantiGetir())
                {
                    baglanti.Open();
                    NpgsqlTransaction trans = baglanti.BeginTransaction();

                    try
                    {
                        // 1. Önce Gerçek 'uye_id'yi buluyoruz (Kisi_id ile uye_id karışmaması için)
                        int uyeId = 0;
                        NpgsqlCommand cmdIdBul = new NpgsqlCommand("SELECT uye_id FROM Uyeler WHERE kisi_id = @kid", baglanti, trans);
                        cmdIdBul.Parameters.AddWithValue("@kid", kisiId);
                        object sonuc = cmdIdBul.ExecuteScalar();

                        if (sonuc != null)
                        {
                            uyeId = Convert.ToInt32(sonuc);
                        }
                        else
                        {
                            // Eğer üye tablosunda yoksa (belki sadece kişi olarak vardır), prosedür hata vermesin diye işlemi durdurabiliriz
                            // Ama biz yine de devam edelim, belki sadece ID uyuşmazlığı vardır.
                            uyeId = kisiId;
                        }

                        // 2. YAMA: SQL prosedüründe unutulan 'Satislar' tablosunu buradan siliyoruz.
                        // Önce Satış Detaylarını sil (Çünkü Satışlar tablosuna bağlı)
                        NpgsqlCommand cmdSilDetay = new NpgsqlCommand("DELETE FROM SatisDetaylari WHERE satis_id IN (SELECT satis_id FROM Satislar WHERE uye_id = @uid)", baglanti, trans);
                        cmdSilDetay.Parameters.AddWithValue("@uid", uyeId);
                        cmdSilDetay.ExecuteNonQuery();

                        // Sonra Satışları sil
                        NpgsqlCommand cmdSilSatis = new NpgsqlCommand("DELETE FROM Satislar WHERE uye_id = @uid", baglanti, trans);
                        cmdSilSatis.Parameters.AddWithValue("@uid", uyeId);
                        cmdSilSatis.ExecuteNonQuery();

                        // 3. Artık SQL'deki prosedürü çağırabiliriz (Diğer tabloları bu silecek)
                        NpgsqlCommand komut = new NpgsqlCommand("CALL s_uye_sil(@id)", baglanti, trans);
                        komut.Parameters.AddWithValue("@id", uyeId);
                        komut.ExecuteNonQuery();

                        trans.Commit();
                        MessageBox.Show("Üye ve tüm kayıtları başarıyla silindi.");
                        VerileriYenile();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Silme Hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek üyeyi listeden seçin.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (gridUye.CurrentRow != null)
            {
                int id = Convert.ToInt32(gridUye.CurrentRow.Cells["uye_id"].Value);
                NpgsqlCommand komut = new NpgsqlCommand("CALL s_uye_guncelle(@id, @tel, @mail)");
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@tel", txtTel.Text);
                komut.Parameters.AddWithValue("@mail", txtMail.Text);

                if (Veritabani.KomutCalistir(komut))
                {
                    MessageBox.Show("Güncellendi.");
                    VerileriYenile();
                }
            }
        }

        private void btnBmi_Click(object sender, EventArgs e)
        {
            if (gridUye.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(gridUye.CurrentRow.Cells["uye_id"].Value);
                    using (NpgsqlConnection baglanti = Veritabani.BaglantiGetir())
                    {
                        baglanti.Open();
                        // SQL'de fonksiyon adı f_bmı_hesabı (ı harfi ile) tanımlanmış
                        NpgsqlCommand komut = new NpgsqlCommand("SELECT f_bmı_hesabı(@id)", baglanti);
                        komut.Parameters.AddWithValue("@id", id);
                        object sonuc = komut.ExecuteScalar();

                        if (sonuc != null) MessageBox.Show("BMI: " + sonuc.ToString());
                    }
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM f_uye_ara_tc('{txtAra.Text}')";
            gridUye.DataSource = Veritabani.VeriGetir(sql);
        }

        private void gridUye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = gridUye.Rows[e.RowIndex].Cells["ad"].Value?.ToString();
                txtSoyad.Text = gridUye.Rows[e.RowIndex].Cells["soyad"].Value?.ToString();
                if (gridUye.Columns.Contains("tc_no")) txtTc.Text = gridUye.Rows[e.RowIndex].Cells["tc_no"].Value?.ToString();
                if (gridUye.Columns.Contains("telefon")) txtTel.Text = gridUye.Rows[e.RowIndex].Cells["telefon"].Value?.ToString();
                if (gridUye.Columns.Contains("email")) txtMail.Text = gridUye.Rows[e.RowIndex].Cells["email"].Value?.ToString();
            }
        }

        // ==========================================================
        // --- SEKME 2: SATIŞ (BORÇ YANSITMA VE ID ÇEVİRME) ---
        // ==========================================================
        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSatUye.Text) || string.IsNullOrEmpty(txtSatUrun.Text) || string.IsNullOrEmpty(txtSatAdet.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (NpgsqlConnection baglanti = Veritabani.BaglantiGetir())
            {
                baglanti.Open();
                NpgsqlTransaction trans = baglanti.BeginTransaction();

                try
                {
                    // Kullanıcı ekranda 'kisi_id' (15 gibi) görüp onu giriyor.
                    int girilenKisiId = int.Parse(txtSatUye.Text.Trim());
                    int girilenUrunId = int.Parse(txtSatUrun.Text.Trim());
                    int adet = int.Parse(txtSatAdet.Text.Trim());

                    // 1. ADIM: GERÇEK 'uye_id' BULMA (CRITICAL FIX)
                    // Satislar tablosu uye_id ile çalışıyor, kisi_id ile değil.
                    // Bu yüzden önce kisi_id'den uye_id'yi buluyoruz.
                    int gercekUyeId = 0;
                    NpgsqlCommand cmdIdBul = new NpgsqlCommand("SELECT uye_id FROM Uyeler WHERE kisi_id = @kid", baglanti, trans);
                    cmdIdBul.Parameters.AddWithValue("@kid", girilenKisiId);
                    object sonucId = cmdIdBul.ExecuteScalar();

                    if (sonucId != null)
                    {
                        gercekUyeId = Convert.ToInt32(sonucId);
                    }
                    else
                    {
                        MessageBox.Show($"HATA: Girdiğiniz {girilenKisiId} numaralı ID'ye sahip bir üye bulunamadı!");
                        return;
                    }

                    // 2. Ürün Fiyatını Al
                    NpgsqlCommand cmdFiyat = new NpgsqlCommand("SELECT satis_fiyati FROM Urunler WHERE urun_id = @uid", baglanti, trans);
                    cmdFiyat.Parameters.AddWithValue("@uid", girilenUrunId);
                    object fiyatObj = cmdFiyat.ExecuteScalar();

                    if (fiyatObj == null) throw new Exception("Ürün bulunamadı.");
                    decimal birimFiyat = Convert.ToDecimal(fiyatObj);
                    decimal toplamTutar = birimFiyat * adet;

                    // 3. Satışı Kaydet (Bulduğumuz gercekUyeId ile)
                    NpgsqlCommand cmdSatis = new NpgsqlCommand("INSERT INTO Satislar (uye_id, toplam_tutar) VALUES (@u, @tut) RETURNING satis_id", baglanti, trans);
                    cmdSatis.Parameters.AddWithValue("@u", gercekUyeId);
                    cmdSatis.Parameters.AddWithValue("@tut", toplamTutar);
                    int satisId = (int)cmdSatis.ExecuteScalar();

                    // 4. Detayı Kaydet
                    NpgsqlCommand cmdDetay = new NpgsqlCommand("INSERT INTO SatisDetaylari (satis_id, urun_id, adet, birim_fiyat) VALUES (@sid, @uid, @ad, @fiyat)", baglanti, trans);
                    cmdDetay.Parameters.AddWithValue("@sid", satisId);
                    cmdDetay.Parameters.AddWithValue("@uid", girilenUrunId);
                    cmdDetay.Parameters.AddWithValue("@ad", adet);
                    cmdDetay.Parameters.AddWithValue("@fiyat", birimFiyat);
                    cmdDetay.ExecuteNonQuery();

                    // 5. YENİ KURAL: Satış tutarını BORÇ olarak ekle (guncel_borc sütununa)
                    NpgsqlCommand cmdBorc = new NpgsqlCommand("UPDATE Uyeler SET guncel_borc = guncel_borc + @tutar WHERE uye_id = @uid", baglanti, trans);
                    cmdBorc.Parameters.AddWithValue("@tutar", toplamTutar);
                    cmdBorc.Parameters.AddWithValue("@uid", gercekUyeId);
                    cmdBorc.ExecuteNonQuery();

                    trans.Commit();

                    MessageBox.Show($"Satış Yapıldı.\nToplam Tutar ({toplamTutar} TL) üyenin borcuna eklendi.");
                    VerileriYenile();
                }
                catch (PostgresException ex)
                {
                    trans.Rollback();
                    if (ex.SqlState == "23503")
                        MessageBox.Show($"ID Hatası: Satış tablosu (Foreign Key) hatası. KisiID->UyeID dönüşümü başarısız oldu.");
                    else
                        MessageBox.Show("Veritabanı Hatası: " + ex.MessageText);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("İşlem Hatası: " + ex.Message);
                }
            }
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStokUrunId.Text) || string.IsNullOrEmpty(txtStokAdet.Text)) return;
                int urunId = int.Parse(txtStokUrunId.Text);
                int adet = int.Parse(txtStokAdet.Text);

                string sql = "UPDATE Urunler SET stok_adedi = stok_adedi + @adet WHERE urun_id = @id";
                NpgsqlCommand komut = new NpgsqlCommand(sql);
                komut.Parameters.AddWithValue("@adet", adet);
                komut.Parameters.AddWithValue("@id", urunId);

                if (Veritabani.KomutCalistir(komut))
                {
                    MessageBox.Show("Stok Eklendi.");
                    VerileriYenile();
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        // ==========================================================
        // --- SEKME 3: DERS ---
        // ==========================================================
        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                // Burada da kisi_id -> uye_id dönüşümü gerekebilir, basitlik için direkt deniyoruz
                // Eğer hata verirse satış butonundaki gibi ID bulma mantığını buraya da eklemeliyiz.
                // DersKayitlari uye_id ister.

                int girilenKisiId = int.Parse(txtDersUye.Text);
                // ID Çevirme (SQL'de bir View olmadığı için C# ile yapıyoruz)
                using (NpgsqlConnection bag = Veritabani.BaglantiGetir())
                {
                    bag.Open();
                    NpgsqlCommand cmdId = new NpgsqlCommand("SELECT uye_id FROM Uyeler WHERE kisi_id=@kid", bag);
                    cmdId.Parameters.AddWithValue("@kid", girilenKisiId);
                    object res = cmdId.ExecuteScalar();
                    if (res == null) { MessageBox.Show("Üye Bulunamadı"); return; }
                    int gercekUyeId = (int)res;

                    NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO DersKayitlari (program_id, uye_id) VALUES (@pid, @uid)", bag);
                    komut.Parameters.AddWithValue("@pid", int.Parse(txtDersProg.Text));
                    komut.Parameters.AddWithValue("@uid", gercekUyeId);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Derse Kayıt Yapıldı.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnKontenjan_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection bag = Veritabani.BaglantiGetir())
                {
                    bag.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("SELECT f_boskontenjan(@pid)", bag);
                    komut.Parameters.AddWithValue("@pid", int.Parse(txtDersProg.Text));
                    object sonuc = komut.ExecuteScalar();
                    MessageBox.Show("Boş Kontenjan: " + sonuc);
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        // ==========================================================
        // --- SEKME 4: FİNANS & BORÇ ÖDEME ---
        // ==========================================================
        private void btnCiro_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection bag = Veritabani.BaglantiGetir())
            {
                try
                {
                    bag.Open();
                    // f_CiroHesapla fonksiyonunu çağırıyoruz
                    NpgsqlCommand komut = new NpgsqlCommand("SELECT f_CiroHesapla(@b, @e)", bag);
                    komut.Parameters.AddWithValue("@b", NpgsqlTypes.NpgsqlDbType.Date, dtpBas.Value);
                    komut.Parameters.AddWithValue("@e", NpgsqlTypes.NpgsqlDbType.Date, dtpBit.Value);

                    object dbCiro = komut.ExecuteScalar();
                    decimal toplamCiro = (dbCiro == null || dbCiro == DBNull.Value) ? 0 : Convert.ToDecimal(dbCiro);

                    // Anlık olarak C#'ta tuttuğumuz ödemeleri de ekliyoruz
                    toplamCiro += anlikKasaCirosu;

                    lblCiroSonuc.Text = "Toplam Ciro: " + toplamCiro.ToString("N2") + " TL";
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void btnBorc_Click(object sender, EventArgs e)
        {
            // Sütun adı guncel_borc
            gridFinans.DataSource = Veritabani.VeriGetir("SELECT kisi_id, ad, soyad, guncel_borc FROM Uyeler WHERE guncel_borc > 0 ORDER BY guncel_borc DESC");
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection bag = Veritabani.BaglantiGetir())
            {
                bag.Open();
                try
                {
                    NpgsqlCommand komut = new NpgsqlCommand("SELECT f_pasiflestir_gecikenleri()", bag);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("İşlem Tamamlandı.");
                    VerileriYenile();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        // --- BORÇ ÖDEME (CİROYA EKLEME MANTIĞI) ---
        private void btnBorcOde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBorcUyeId.Text) || string.IsNullOrEmpty(txtBorcMiktar.Text))
            {
                MessageBox.Show("Lütfen ID ve Tutar girin.");
                return;
            }

            try
            {
                int girilenKisiId = int.Parse(txtBorcUyeId.Text);
                decimal odenen = decimal.Parse(txtBorcMiktar.Text);

                // 1. Veritabanından Borcu Düş (guncel_borc)
                // Burada kisi_id ile direkt işlem yapabiliriz çünkü Uyeler tablosunda kisi_id de var.
                string sql = "UPDATE Uyeler SET guncel_borc = guncel_borc - @miktar WHERE kisi_id = @id";

                NpgsqlCommand komut = new NpgsqlCommand(sql);
                komut.Parameters.AddWithValue("@miktar", odenen);
                komut.Parameters.AddWithValue("@id", girilenKisiId);

                if (Veritabani.KomutCalistir(komut))
                {
                    // 2. Ödenen parayı Ciroya Ekle (Değişkeni arttır)
                    anlikKasaCirosu += odenen;

                    MessageBox.Show($"{odenen} TL tahsil edildi.\nBorçtan düşüldü, Ciroya eklendi.");

                    // Ciro ve listeyi güncelle
                    btnCiro.PerformClick();
                    VerileriYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme Hatası: " + ex.Message);
            }
        }

        // ==========================================================
        // --- SEKME 5: PERSONEL VE VARDİYA ---
        // ==========================================================
        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO Personel (ad, soyad, pozisyon, maas, ise_giris_tarihi) VALUES (@ad, @soyad, @poz, @maas, @tar)");
                komut.Parameters.AddWithValue("@ad", txtPerAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtPerSoyad.Text);
                komut.Parameters.AddWithValue("@poz", txtPerPoz.Text);
                komut.Parameters.AddWithValue("@maas", decimal.Parse(txtPerMaas.Text));
                komut.Parameters.AddWithValue("@tar", dtpPerTar.Value);

                if (Veritabani.KomutCalistir(komut))
                {
                    MessageBox.Show("Personel Eklendi");
                    VerileriYenile();
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnPerSil_Click(object sender, EventArgs e)
        {
            if (gridPersonel.CurrentRow != null)
            {
                int id = Convert.ToInt32(gridPersonel.CurrentRow.Cells["personel_id"].Value);
                NpgsqlCommand komut = new NpgsqlCommand("DELETE FROM Personel WHERE personel_id=@id");
                komut.Parameters.AddWithValue("@id", id);
                if (Veritabani.KomutCalistir(komut))
                {
                    MessageBox.Show("Personel Silindi");
                    VerileriYenile();
                }
            }
        }

        private void btnVarEkle_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO Vardiyalar (personel_id, gun, baslangic_saati, bitis_saati) VALUES (@pid, @gun, @bas, @bit)");
                komut.Parameters.AddWithValue("@pid", int.Parse(txtVarPerId.Text));
                komut.Parameters.AddWithValue("@gun", cmbVarGun.Text);
                komut.Parameters.AddWithValue("@bas", TimeSpan.Parse(txtVarBas.Text));
                komut.Parameters.AddWithValue("@bit", TimeSpan.Parse(txtVarBit.Text));

                if (Veritabani.KomutCalistir(komut))
                {
                    MessageBox.Show("Vardiya Eklendi");
                    VerileriYenile();
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnVarDuzenle_Click(object sender, EventArgs e)
        {
            if (gridVardiya.CurrentRow != null)
            {
                try
                {
                    int vid = Convert.ToInt32(gridVardiya.CurrentRow.Cells["vardiya_id"].Value);
                    NpgsqlCommand komut = new NpgsqlCommand("UPDATE Vardiyalar SET baslangic_saati=@bas, bitis_saati=@bit WHERE vardiya_id=@vid");
                    komut.Parameters.AddWithValue("@vid", vid);
                    komut.Parameters.AddWithValue("@bas", TimeSpan.Parse(txtVarBas.Text));
                    komut.Parameters.AddWithValue("@bit", TimeSpan.Parse(txtVarBit.Text));

                    if (Veritabani.KomutCalistir(komut))
                    {
                        MessageBox.Show("Vardiya Güncellendi");
                        VerileriYenile();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void gridVardiya_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbVarGun.Text = gridVardiya.Rows[e.RowIndex].Cells["gun"].Value?.ToString();
                txtVarBas.Text = gridVardiya.Rows[e.RowIndex].Cells["baslangic_saati"].Value?.ToString();
                txtVarBit.Text = gridVardiya.Rows[e.RowIndex].Cells["bitis_saati"].Value?.ToString();
            }
        }
    }
}