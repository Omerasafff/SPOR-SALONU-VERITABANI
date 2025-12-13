namespace VTYS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUye = new System.Windows.Forms.TabPage();
            this.gridUye = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.lblCins = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.tabSatis = new System.Windows.Forms.TabPage();
            this.gridUrun = new System.Windows.Forms.DataGridView();
            this.grpSatis = new System.Windows.Forms.GroupBox();
            this.lblSatUye = new System.Windows.Forms.Label();
            this.txtSatUye = new System.Windows.Forms.TextBox();
            this.lblSatUrun = new System.Windows.Forms.Label();
            this.txtSatUrun = new System.Windows.Forms.TextBox();
            this.lblSatAdet = new System.Windows.Forms.Label();
            this.txtSatAdet = new System.Windows.Forms.TextBox();
            this.btnSatis = new System.Windows.Forms.Button();
            this.grpStok = new System.Windows.Forms.GroupBox();
            this.lblStokUrunId = new System.Windows.Forms.Label();
            this.txtStokUrunId = new System.Windows.Forms.TextBox();
            this.lblStokAdet = new System.Windows.Forms.Label();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.tabDers = new System.Windows.Forms.TabPage();
            this.gridDers = new System.Windows.Forms.DataGridView();
            this.btnKontenjan = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtDersUye = new System.Windows.Forms.TextBox();
            this.lblDersUye = new System.Windows.Forms.Label();
            this.txtDersProg = new System.Windows.Forms.TextBox();
            this.lblDersProg = new System.Windows.Forms.Label();
            this.tabFinans = new System.Windows.Forms.TabPage();
            this.gridFinans = new System.Windows.Forms.DataGridView();
            this.grpBorcOde = new System.Windows.Forms.GroupBox();
            this.lblBorcUyeId = new System.Windows.Forms.Label();
            this.txtBorcUyeId = new System.Windows.Forms.TextBox();
            this.lblBorcMiktar = new System.Windows.Forms.Label();
            this.txtBorcMiktar = new System.Windows.Forms.TextBox();
            this.btnBorcOde = new System.Windows.Forms.Button();
            this.btnPasif = new System.Windows.Forms.Button();
            this.btnBorc = new System.Windows.Forms.Button();
            this.lblCiroSonuc = new System.Windows.Forms.Label();
            this.btnCiro = new System.Windows.Forms.Button();
            this.dtpBit = new System.Windows.Forms.DateTimePicker();
            this.dtpBas = new System.Windows.Forms.DateTimePicker();
            this.tabPersonel = new System.Windows.Forms.TabPage();
            this.gridPersonel = new System.Windows.Forms.DataGridView();
            this.gridVardiya = new System.Windows.Forms.DataGridView();
            this.lblPerAd = new System.Windows.Forms.Label();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.lblPerSoyad = new System.Windows.Forms.Label();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.lblPerPoz = new System.Windows.Forms.Label();
            this.txtPerPoz = new System.Windows.Forms.TextBox();
            this.lblPerMaas = new System.Windows.Forms.Label();
            this.txtPerMaas = new System.Windows.Forms.TextBox();
            this.dtpPerTar = new System.Windows.Forms.DateTimePicker();
            this.btnPerEkle = new System.Windows.Forms.Button();
            this.btnPerSil = new System.Windows.Forms.Button();
            this.lblVarPerId = new System.Windows.Forms.Label();
            this.txtVarPerId = new System.Windows.Forms.TextBox();
            this.lblVarGun = new System.Windows.Forms.Label();
            this.cmbVarGun = new System.Windows.Forms.ComboBox();
            this.lblVarBas = new System.Windows.Forms.Label();
            this.txtVarBas = new System.Windows.Forms.TextBox();
            this.lblVarBit = new System.Windows.Forms.Label();
            this.txtVarBit = new System.Windows.Forms.TextBox();
            this.btnVarEkle = new System.Windows.Forms.Button();
            this.btnVarDuzenle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabUye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).BeginInit();
            this.tabSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            this.grpSatis.SuspendLayout();
            this.grpStok.SuspendLayout();
            this.tabDers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDers)).BeginInit();
            this.tabFinans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinans)).BeginInit();
            this.grpBorcOde.SuspendLayout();
            this.tabPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVardiya)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUye);
            this.tabControl1.Controls.Add(this.tabSatis);
            this.tabControl1.Controls.Add(this.tabDers);
            this.tabControl1.Controls.Add(this.tabFinans);
            this.tabControl1.Controls.Add(this.tabPersonel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUye
            // 
            this.tabUye.Controls.Add(this.gridUye);
            this.tabUye.Controls.Add(this.btnAra);
            this.tabUye.Controls.Add(this.txtAra);
            this.tabUye.Controls.Add(this.btnGuncelle);
            this.tabUye.Controls.Add(this.btnSil);
            this.tabUye.Controls.Add(this.btnEkle);
            this.tabUye.Controls.Add(this.cmbCins);
            this.tabUye.Controls.Add(this.lblCins);
            this.tabUye.Controls.Add(this.txtMail);
            this.tabUye.Controls.Add(this.lblMail);
            this.tabUye.Controls.Add(this.txtTel);
            this.tabUye.Controls.Add(this.lblTel);
            this.tabUye.Controls.Add(this.txtTc);
            this.tabUye.Controls.Add(this.lblTc);
            this.tabUye.Controls.Add(this.txtSoyad);
            this.tabUye.Controls.Add(this.lblSoyad);
            this.tabUye.Controls.Add(this.txtAd);
            this.tabUye.Controls.Add(this.lblAd);
            this.tabUye.Location = new System.Drawing.Point(4, 25);
            this.tabUye.Name = "tabUye";
            this.tabUye.Size = new System.Drawing.Size(942, 621);
            this.tabUye.TabIndex = 0;
            this.tabUye.Text = "Üye İşlemleri";
            // 
            // gridUye
            // 
            this.gridUye.ColumnHeadersHeight = 29;
            this.gridUye.Location = new System.Drawing.Point(20, 160);
            this.gridUye.Name = "gridUye";
            this.gridUye.RowHeadersWidth = 51;
            this.gridUye.Size = new System.Drawing.Size(880, 380);
            this.gridUye.TabIndex = 0;
            this.gridUye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUye_CellClick);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(660, 18);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "TC ARA";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(550, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(240, 120);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(160, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(80, 120);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbCins
            // 
            this.cmbCins.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbCins.Location = new System.Drawing.Point(280, 77);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(120, 24);
            this.cmbCins.TabIndex = 7;
            // 
            // lblCins
            // 
            this.lblCins.Location = new System.Drawing.Point(220, 80);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(100, 23);
            this.lblCins.TabIndex = 8;
            this.lblCins.Text = "Cinsiyet:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(80, 77);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(120, 22);
            this.txtMail.TabIndex = 9;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(20, 80);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(100, 23);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(280, 47);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(120, 22);
            this.txtTel.TabIndex = 11;
            // 
            // lblTel
            // 
            this.lblTel.Location = new System.Drawing.Point(220, 50);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 23);
            this.lblTel.TabIndex = 12;
            this.lblTel.Text = "Tel:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(80, 47);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(120, 22);
            this.txtTc.TabIndex = 13;
            // 
            // lblTc
            // 
            this.lblTc.Location = new System.Drawing.Point(20, 50);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(100, 23);
            this.lblTc.TabIndex = 14;
            this.lblTc.Text = "TC No:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(280, 17);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(120, 22);
            this.txtSoyad.TabIndex = 15;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Location = new System.Drawing.Point(220, 20);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(100, 23);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(80, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 22);
            this.txtAd.TabIndex = 17;
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(20, 20);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(100, 23);
            this.lblAd.TabIndex = 18;
            this.lblAd.Text = "Ad:";
            // 
            // tabSatis
            // 
            this.tabSatis.Controls.Add(this.gridUrun);
            this.tabSatis.Controls.Add(this.grpSatis);
            this.tabSatis.Controls.Add(this.grpStok);
            this.tabSatis.Location = new System.Drawing.Point(4, 25);
            this.tabSatis.Name = "tabSatis";
            this.tabSatis.Size = new System.Drawing.Size(942, 621);
            this.tabSatis.TabIndex = 1;
            this.tabSatis.Text = "Satış & Stok";
            // 
            // gridUrun
            // 
            this.gridUrun.ColumnHeadersHeight = 29;
            this.gridUrun.Location = new System.Drawing.Point(20, 100);
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.RowHeadersWidth = 51;
            this.gridUrun.Size = new System.Drawing.Size(890, 480);
            this.gridUrun.TabIndex = 0;
            // 
            // grpSatis
            // 
            this.grpSatis.Controls.Add(this.lblSatUye);
            this.grpSatis.Controls.Add(this.txtSatUye);
            this.grpSatis.Controls.Add(this.lblSatUrun);
            this.grpSatis.Controls.Add(this.txtSatUrun);
            this.grpSatis.Controls.Add(this.lblSatAdet);
            this.grpSatis.Controls.Add(this.txtSatAdet);
            this.grpSatis.Controls.Add(this.btnSatis);
            this.grpSatis.Location = new System.Drawing.Point(20, 10);
            this.grpSatis.Name = "grpSatis";
            this.grpSatis.Size = new System.Drawing.Size(600, 70);
            this.grpSatis.TabIndex = 1;
            this.grpSatis.TabStop = false;
            this.grpSatis.Text = "Ürün Satışı";
            // 
            // lblSatUye
            // 
            this.lblSatUye.Location = new System.Drawing.Point(-3, 30);
            this.lblSatUye.Name = "lblSatUye";
            this.lblSatUye.Size = new System.Drawing.Size(57, 23);
            this.lblSatUye.TabIndex = 0;
            this.lblSatUye.Text = "Üye ID:";
            // 
            // txtSatUye
            // 
            this.txtSatUye.Location = new System.Drawing.Point(60, 27);
            this.txtSatUye.Name = "txtSatUye";
            this.txtSatUye.Size = new System.Drawing.Size(50, 22);
            this.txtSatUye.TabIndex = 1;
            // 
            // lblSatUrun
            // 
            this.lblSatUrun.Location = new System.Drawing.Point(116, 30);
            this.lblSatUrun.Name = "lblSatUrun";
            this.lblSatUrun.Size = new System.Drawing.Size(58, 23);
            this.lblSatUrun.TabIndex = 2;
            this.lblSatUrun.Text = "Ürün ID:";
            // 
            // txtSatUrun
            // 
            this.txtSatUrun.Location = new System.Drawing.Point(180, 27);
            this.txtSatUrun.Name = "txtSatUrun";
            this.txtSatUrun.Size = new System.Drawing.Size(50, 22);
            this.txtSatUrun.TabIndex = 3;
            // 
            // lblSatAdet
            // 
            this.lblSatAdet.Location = new System.Drawing.Point(236, 27);
            this.lblSatAdet.Name = "lblSatAdet";
            this.lblSatAdet.Size = new System.Drawing.Size(48, 23);
            this.lblSatAdet.TabIndex = 4;
            this.lblSatAdet.Text = "Adet:";
            // 
            // txtSatAdet
            // 
            this.txtSatAdet.Location = new System.Drawing.Point(290, 27);
            this.txtSatAdet.Name = "txtSatAdet";
            this.txtSatAdet.Size = new System.Drawing.Size(50, 22);
            this.txtSatAdet.TabIndex = 5;
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(380, 25);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(150, 30);
            this.btnSatis.TabIndex = 6;
            this.btnSatis.Text = "SATIŞ YAP";
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // grpStok
            // 
            this.grpStok.Controls.Add(this.lblStokUrunId);
            this.grpStok.Controls.Add(this.txtStokUrunId);
            this.grpStok.Controls.Add(this.lblStokAdet);
            this.grpStok.Controls.Add(this.txtStokAdet);
            this.grpStok.Controls.Add(this.btnStokEkle);
            this.grpStok.Location = new System.Drawing.Point(630, 10);
            this.grpStok.Name = "grpStok";
            this.grpStok.Size = new System.Drawing.Size(280, 70);
            this.grpStok.TabIndex = 2;
            this.grpStok.TabStop = false;
            this.grpStok.Text = "Hızlı Stok Ekleme";
            // 
            // lblStokUrunId
            // 
            this.lblStokUrunId.AutoSize = true;
            this.lblStokUrunId.Location = new System.Drawing.Point(10, 30);
            this.lblStokUrunId.Name = "lblStokUrunId";
            this.lblStokUrunId.Size = new System.Drawing.Size(23, 16);
            this.lblStokUrunId.TabIndex = 0;
            this.lblStokUrunId.Text = "ID:";
            // 
            // txtStokUrunId
            // 
            this.txtStokUrunId.Location = new System.Drawing.Point(35, 27);
            this.txtStokUrunId.Name = "txtStokUrunId";
            this.txtStokUrunId.Size = new System.Drawing.Size(40, 22);
            this.txtStokUrunId.TabIndex = 1;
            // 
            // lblStokAdet
            // 
            this.lblStokAdet.AutoSize = true;
            this.lblStokAdet.Location = new System.Drawing.Point(90, 30);
            this.lblStokAdet.Name = "lblStokAdet";
            this.lblStokAdet.Size = new System.Drawing.Size(38, 16);
            this.lblStokAdet.TabIndex = 2;
            this.lblStokAdet.Text = "Adet:";
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(125, 27);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(40, 22);
            this.txtStokAdet.TabIndex = 3;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Location = new System.Drawing.Point(180, 25);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(80, 30);
            this.btnStokEkle.TabIndex = 4;
            this.btnStokEkle.Text = "EKLE";
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // tabDers
            // 
            this.tabDers.Controls.Add(this.gridDers);
            this.tabDers.Controls.Add(this.btnKontenjan);
            this.tabDers.Controls.Add(this.btnKayit);
            this.tabDers.Controls.Add(this.txtDersUye);
            this.tabDers.Controls.Add(this.lblDersUye);
            this.tabDers.Controls.Add(this.txtDersProg);
            this.tabDers.Controls.Add(this.lblDersProg);
            this.tabDers.Location = new System.Drawing.Point(4, 25);
            this.tabDers.Name = "tabDers";
            this.tabDers.Size = new System.Drawing.Size(942, 621);
            this.tabDers.TabIndex = 2;
            this.tabDers.Text = "Ders İşlemleri";
            // 
            // gridDers
            // 
            this.gridDers.ColumnHeadersHeight = 29;
            this.gridDers.Location = new System.Drawing.Point(20, 80);
            this.gridDers.Name = "gridDers";
            this.gridDers.RowHeadersWidth = 51;
            this.gridDers.Size = new System.Drawing.Size(880, 460);
            this.gridDers.TabIndex = 0;
            // 
            // btnKontenjan
            // 
            this.btnKontenjan.Location = new System.Drawing.Point(500, 25);
            this.btnKontenjan.Name = "btnKontenjan";
            this.btnKontenjan.Size = new System.Drawing.Size(120, 23);
            this.btnKontenjan.TabIndex = 1;
            this.btnKontenjan.Text = "KONTENJAN SOR";
            this.btnKontenjan.Click += new System.EventHandler(this.btnKontenjan_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(400, 25);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "KAYIT OL";
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtDersUye
            // 
            this.txtDersUye.Location = new System.Drawing.Point(260, 27);
            this.txtDersUye.Name = "txtDersUye";
            this.txtDersUye.Size = new System.Drawing.Size(100, 22);
            this.txtDersUye.TabIndex = 3;
            // 
            // lblDersUye
            // 
            this.lblDersUye.Location = new System.Drawing.Point(200, 30);
            this.lblDersUye.Name = "lblDersUye";
            this.lblDersUye.Size = new System.Drawing.Size(100, 23);
            this.lblDersUye.TabIndex = 4;
            this.lblDersUye.Text = "Üye ID:";
            // 
            // txtDersProg
            // 
            this.txtDersProg.Location = new System.Drawing.Point(80, 27);
            this.txtDersProg.Name = "txtDersProg";
            this.txtDersProg.Size = new System.Drawing.Size(100, 22);
            this.txtDersProg.TabIndex = 5;
            // 
            // lblDersProg
            // 
            this.lblDersProg.Location = new System.Drawing.Point(20, 30);
            this.lblDersProg.Name = "lblDersProg";
            this.lblDersProg.Size = new System.Drawing.Size(100, 23);
            this.lblDersProg.TabIndex = 6;
            this.lblDersProg.Text = "Prog ID:";
            // 
            // tabFinans
            // 
            this.tabFinans.Controls.Add(this.gridFinans);
            this.tabFinans.Controls.Add(this.grpBorcOde);
            this.tabFinans.Controls.Add(this.btnPasif);
            this.tabFinans.Controls.Add(this.btnBorc);
            this.tabFinans.Controls.Add(this.lblCiroSonuc);
            this.tabFinans.Controls.Add(this.btnCiro);
            this.tabFinans.Controls.Add(this.dtpBit);
            this.tabFinans.Controls.Add(this.dtpBas);
            this.tabFinans.Location = new System.Drawing.Point(4, 25);
            this.tabFinans.Name = "tabFinans";
            this.tabFinans.Size = new System.Drawing.Size(942, 621);
            this.tabFinans.TabIndex = 3;
            this.tabFinans.Text = "Finans & Rapor";
            // 
            // gridFinans
            // 
            this.gridFinans.ColumnHeadersHeight = 29;
            this.gridFinans.Location = new System.Drawing.Point(20, 120);
            this.gridFinans.Name = "gridFinans";
            this.gridFinans.RowHeadersWidth = 51;
            this.gridFinans.Size = new System.Drawing.Size(880, 420);
            this.gridFinans.TabIndex = 0;
            // 
            // grpBorcOde
            // 
            this.grpBorcOde.Controls.Add(this.lblBorcUyeId);
            this.grpBorcOde.Controls.Add(this.txtBorcUyeId);
            this.grpBorcOde.Controls.Add(this.lblBorcMiktar);
            this.grpBorcOde.Controls.Add(this.txtBorcMiktar);
            this.grpBorcOde.Controls.Add(this.btnBorcOde);
            this.grpBorcOde.Location = new System.Drawing.Point(400, 60);
            this.grpBorcOde.Name = "grpBorcOde";
            this.grpBorcOde.Size = new System.Drawing.Size(500, 50);
            this.grpBorcOde.TabIndex = 1;
            this.grpBorcOde.TabStop = false;
            this.grpBorcOde.Text = "Borç Ödeme";
            // 
            // lblBorcUyeId
            // 
            this.lblBorcUyeId.AutoSize = true;
            this.lblBorcUyeId.Location = new System.Drawing.Point(10, 20);
            this.lblBorcUyeId.Name = "lblBorcUyeId";
            this.lblBorcUyeId.Size = new System.Drawing.Size(51, 16);
            this.lblBorcUyeId.TabIndex = 0;
            this.lblBorcUyeId.Text = "Üye ID:";
            // 
            // txtBorcUyeId
            // 
            this.txtBorcUyeId.Location = new System.Drawing.Point(60, 17);
            this.txtBorcUyeId.Name = "txtBorcUyeId";
            this.txtBorcUyeId.Size = new System.Drawing.Size(60, 22);
            this.txtBorcUyeId.TabIndex = 1;
            // 
            // lblBorcMiktar
            // 
            this.lblBorcMiktar.AutoSize = true;
            this.lblBorcMiktar.Location = new System.Drawing.Point(140, 20);
            this.lblBorcMiktar.Name = "lblBorcMiktar";
            this.lblBorcMiktar.Size = new System.Drawing.Size(41, 16);
            this.lblBorcMiktar.TabIndex = 2;
            this.lblBorcMiktar.Text = "Tutar:";
            // 
            // txtBorcMiktar
            // 
            this.txtBorcMiktar.Location = new System.Drawing.Point(180, 17);
            this.txtBorcMiktar.Name = "txtBorcMiktar";
            this.txtBorcMiktar.Size = new System.Drawing.Size(80, 22);
            this.txtBorcMiktar.TabIndex = 3;
            // 
            // btnBorcOde
            // 
            this.btnBorcOde.Location = new System.Drawing.Point(280, 15);
            this.btnBorcOde.Name = "btnBorcOde";
            this.btnBorcOde.Size = new System.Drawing.Size(75, 23);
            this.btnBorcOde.TabIndex = 4;
            this.btnBorcOde.Text = "BORÇ DÜŞ";
            this.btnBorcOde.Click += new System.EventHandler(this.btnBorcOde_Click);
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(200, 70);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(180, 30);
            this.btnPasif.TabIndex = 2;
            this.btnPasif.Text = "GECİKENLERİ PASİF YAP";
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // btnBorc
            // 
            this.btnBorc.Location = new System.Drawing.Point(20, 70);
            this.btnBorc.Name = "btnBorc";
            this.btnBorc.Size = new System.Drawing.Size(150, 30);
            this.btnBorc.TabIndex = 3;
            this.btnBorc.Text = "BORÇLULARI GETİR";
            this.btnBorc.Click += new System.EventHandler(this.btnBorc_Click);
            // 
            // lblCiroSonuc
            // 
            this.lblCiroSonuc.AutoSize = true;
            this.lblCiroSonuc.Location = new System.Drawing.Point(600, 33);
            this.lblCiroSonuc.Name = "lblCiroSonuc";
            this.lblCiroSonuc.Size = new System.Drawing.Size(16, 16);
            this.lblCiroSonuc.TabIndex = 4;
            this.lblCiroSonuc.Text = "...";
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(460, 28);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(75, 23);
            this.btnCiro.TabIndex = 5;
            this.btnCiro.Text = "CİRO HESAPLA";
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // dtpBit
            // 
            this.dtpBit.Location = new System.Drawing.Point(240, 30);
            this.dtpBit.Name = "dtpBit";
            this.dtpBit.Size = new System.Drawing.Size(200, 22);
            this.dtpBit.TabIndex = 6;
            // 
            // dtpBas
            // 
            this.dtpBas.Location = new System.Drawing.Point(20, 30);
            this.dtpBas.Name = "dtpBas";
            this.dtpBas.Size = new System.Drawing.Size(200, 22);
            this.dtpBas.TabIndex = 7;
            // 
            // tabPersonel
            // 
            this.tabPersonel.Controls.Add(this.gridPersonel);
            this.tabPersonel.Controls.Add(this.gridVardiya);
            this.tabPersonel.Controls.Add(this.lblPerAd);
            this.tabPersonel.Controls.Add(this.txtPerAd);
            this.tabPersonel.Controls.Add(this.lblPerSoyad);
            this.tabPersonel.Controls.Add(this.txtPerSoyad);
            this.tabPersonel.Controls.Add(this.lblPerPoz);
            this.tabPersonel.Controls.Add(this.txtPerPoz);
            this.tabPersonel.Controls.Add(this.lblPerMaas);
            this.tabPersonel.Controls.Add(this.txtPerMaas);
            this.tabPersonel.Controls.Add(this.dtpPerTar);
            this.tabPersonel.Controls.Add(this.btnPerEkle);
            this.tabPersonel.Controls.Add(this.btnPerSil);
            this.tabPersonel.Controls.Add(this.lblVarPerId);
            this.tabPersonel.Controls.Add(this.txtVarPerId);
            this.tabPersonel.Controls.Add(this.lblVarGun);
            this.tabPersonel.Controls.Add(this.cmbVarGun);
            this.tabPersonel.Controls.Add(this.lblVarBas);
            this.tabPersonel.Controls.Add(this.txtVarBas);
            this.tabPersonel.Controls.Add(this.lblVarBit);
            this.tabPersonel.Controls.Add(this.txtVarBit);
            this.tabPersonel.Controls.Add(this.btnVarEkle);
            this.tabPersonel.Controls.Add(this.btnVarDuzenle);
            this.tabPersonel.Location = new System.Drawing.Point(4, 25);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.Size = new System.Drawing.Size(942, 621);
            this.tabPersonel.TabIndex = 4;
            this.tabPersonel.Text = "Personel & Vardiya";
            // 
            // gridPersonel
            // 
            this.gridPersonel.ColumnHeadersHeight = 29;
            this.gridPersonel.Location = new System.Drawing.Point(20, 80);
            this.gridPersonel.Name = "gridPersonel";
            this.gridPersonel.RowHeadersWidth = 51;
            this.gridPersonel.Size = new System.Drawing.Size(880, 180);
            this.gridPersonel.TabIndex = 0;
            // 
            // gridVardiya
            // 
            this.gridVardiya.ColumnHeadersHeight = 29;
            this.gridVardiya.Location = new System.Drawing.Point(20, 310);
            this.gridVardiya.Name = "gridVardiya";
            this.gridVardiya.RowHeadersWidth = 51;
            this.gridVardiya.Size = new System.Drawing.Size(880, 230);
            this.gridVardiya.TabIndex = 1;
            this.gridVardiya.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVardiya_CellClick);
            // 
            // lblPerAd
            // 
            this.lblPerAd.Location = new System.Drawing.Point(8, 22);
            this.lblPerAd.Name = "lblPerAd";
            this.lblPerAd.Size = new System.Drawing.Size(54, 23);
            this.lblPerAd.TabIndex = 2;
            this.lblPerAd.Text = "Ad:";
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(80, 17);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(100, 22);
            this.txtPerAd.TabIndex = 3;
            // 
            // lblPerSoyad
            // 
            this.lblPerSoyad.Location = new System.Drawing.Point(186, 20);
            this.lblPerSoyad.Name = "lblPerSoyad";
            this.lblPerSoyad.Size = new System.Drawing.Size(68, 23);
            this.lblPerSoyad.TabIndex = 4;
            this.lblPerSoyad.Text = "Soyad:";
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(260, 17);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtPerSoyad.TabIndex = 5;
            // 
            // lblPerPoz
            // 
            this.lblPerPoz.Location = new System.Drawing.Point(8, 50);
            this.lblPerPoz.Name = "lblPerPoz";
            this.lblPerPoz.Size = new System.Drawing.Size(66, 23);
            this.lblPerPoz.TabIndex = 6;
            this.lblPerPoz.Text = "Pozisyon:";
            // 
            // txtPerPoz
            // 
            this.txtPerPoz.Location = new System.Drawing.Point(80, 47);
            this.txtPerPoz.Name = "txtPerPoz";
            this.txtPerPoz.Size = new System.Drawing.Size(100, 22);
            this.txtPerPoz.TabIndex = 7;
            // 
            // lblPerMaas
            // 
            this.lblPerMaas.Location = new System.Drawing.Point(186, 47);
            this.lblPerMaas.Name = "lblPerMaas";
            this.lblPerMaas.Size = new System.Drawing.Size(64, 23);
            this.lblPerMaas.TabIndex = 8;
            this.lblPerMaas.Text = "Maaş:";
            // 
            // txtPerMaas
            // 
            this.txtPerMaas.Location = new System.Drawing.Point(260, 47);
            this.txtPerMaas.Name = "txtPerMaas";
            this.txtPerMaas.Size = new System.Drawing.Size(100, 22);
            this.txtPerMaas.TabIndex = 9;
            // 
            // dtpPerTar
            // 
            this.dtpPerTar.Location = new System.Drawing.Point(380, 17);
            this.dtpPerTar.Name = "dtpPerTar";
            this.dtpPerTar.Size = new System.Drawing.Size(200, 22);
            this.dtpPerTar.TabIndex = 10;
            // 
            // btnPerEkle
            // 
            this.btnPerEkle.Location = new System.Drawing.Point(380, 45);
            this.btnPerEkle.Name = "btnPerEkle";
            this.btnPerEkle.Size = new System.Drawing.Size(110, 25);
            this.btnPerEkle.TabIndex = 11;
            this.btnPerEkle.Text = "PERSONEL EKLE";
            this.btnPerEkle.Click += new System.EventHandler(this.btnPerEkle_Click);
            // 
            // btnPerSil
            // 
            this.btnPerSil.Location = new System.Drawing.Point(500, 45);
            this.btnPerSil.Name = "btnPerSil";
            this.btnPerSil.Size = new System.Drawing.Size(80, 25);
            this.btnPerSil.TabIndex = 12;
            this.btnPerSil.Text = "SİL";
            this.btnPerSil.Click += new System.EventHandler(this.btnPerSil_Click);
            // 
            // lblVarPerId
            // 
            this.lblVarPerId.Location = new System.Drawing.Point(8, 280);
            this.lblVarPerId.Name = "lblVarPerId";
            this.lblVarPerId.Size = new System.Drawing.Size(66, 23);
            this.lblVarPerId.TabIndex = 13;
            this.lblVarPerId.Text = "Pers ID:";
            // 
            // txtVarPerId
            // 
            this.txtVarPerId.Location = new System.Drawing.Point(80, 277);
            this.txtVarPerId.Name = "txtVarPerId";
            this.txtVarPerId.Size = new System.Drawing.Size(60, 22);
            this.txtVarPerId.TabIndex = 14;
            // 
            // lblVarGun
            // 
            this.lblVarGun.Location = new System.Drawing.Point(150, 280);
            this.lblVarGun.Name = "lblVarGun";
            this.lblVarGun.Size = new System.Drawing.Size(40, 23);
            this.lblVarGun.TabIndex = 15;
            this.lblVarGun.Text = "Gün:";
            // 
            // cmbVarGun
            // 
            this.cmbVarGun.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cmbVarGun.Location = new System.Drawing.Point(190, 277);
            this.cmbVarGun.Name = "cmbVarGun";
            this.cmbVarGun.Size = new System.Drawing.Size(100, 24);
            this.cmbVarGun.TabIndex = 16;
            // 
            // lblVarBas
            // 
            this.lblVarBas.Location = new System.Drawing.Point(296, 280);
            this.lblVarBas.Name = "lblVarBas";
            this.lblVarBas.Size = new System.Drawing.Size(48, 23);
            this.lblVarBas.TabIndex = 17;
            this.lblVarBas.Text = "Başla:";
            // 
            // txtVarBas
            // 
            this.txtVarBas.Location = new System.Drawing.Point(350, 277);
            this.txtVarBas.Name = "txtVarBas";
            this.txtVarBas.Size = new System.Drawing.Size(60, 22);
            this.txtVarBas.TabIndex = 18;
            this.txtVarBas.Text = "09:00";
            // 
            // lblVarBit
            // 
            this.lblVarBit.Location = new System.Drawing.Point(416, 280);
            this.lblVarBit.Name = "lblVarBit";
            this.lblVarBit.Size = new System.Drawing.Size(44, 23);
            this.lblVarBit.TabIndex = 19;
            this.lblVarBit.Text = "Bitiş:";
            // 
            // txtVarBit
            // 
            this.txtVarBit.Location = new System.Drawing.Point(460, 277);
            this.txtVarBit.Name = "txtVarBit";
            this.txtVarBit.Size = new System.Drawing.Size(60, 22);
            this.txtVarBit.TabIndex = 20;
            this.txtVarBit.Text = "17:00";
            // 
            // btnVarEkle
            // 
            this.btnVarEkle.Location = new System.Drawing.Point(550, 275);
            this.btnVarEkle.Name = "btnVarEkle";
            this.btnVarEkle.Size = new System.Drawing.Size(120, 25);
            this.btnVarEkle.TabIndex = 21;
            this.btnVarEkle.Text = "VARDİYA EKLE";
            this.btnVarEkle.Click += new System.EventHandler(this.btnVarEkle_Click);
            // 
            // btnVarDuzenle
            // 
            this.btnVarDuzenle.Location = new System.Drawing.Point(680, 275);
            this.btnVarDuzenle.Name = "btnVarDuzenle";
            this.btnVarDuzenle.Size = new System.Drawing.Size(120, 25);
            this.btnVarDuzenle.TabIndex = 22;
            this.btnVarDuzenle.Text = "SAAT GÜNCELLE";
            this.btnVarDuzenle.Click += new System.EventHandler(this.btnVarDuzenle_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Spor Salonu Yönetimi - VTYS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUye.ResumeLayout(false);
            this.tabUye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).EndInit();
            this.tabSatis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            this.grpSatis.ResumeLayout(false);
            this.grpSatis.PerformLayout();
            this.grpStok.ResumeLayout(false);
            this.grpStok.PerformLayout();
            this.tabDers.ResumeLayout(false);
            this.tabDers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDers)).EndInit();
            this.tabFinans.ResumeLayout(false);
            this.tabFinans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinans)).EndInit();
            this.grpBorcOde.ResumeLayout(false);
            this.grpBorcOde.PerformLayout();
            this.tabPersonel.ResumeLayout(false);
            this.tabPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVardiya)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUye, tabSatis, tabDers, tabFinans, tabPersonel;
        private System.Windows.Forms.DataGridView gridUye, gridUrun, gridDers, gridFinans, gridPersonel, gridVardiya;

        // Üye
        private System.Windows.Forms.Label lblAd, lblSoyad, lblTc, lblTel, lblMail, lblCins;
        private System.Windows.Forms.TextBox txtAd, txtSoyad, txtTc, txtTel, txtMail, txtAra;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.Button btnEkle, btnSil, btnGuncelle, btnAra;

        // Satış & Stok
        private System.Windows.Forms.GroupBox grpSatis, grpStok;
        private System.Windows.Forms.Label lblSatUye, lblSatUrun, lblSatAdet;
        private System.Windows.Forms.TextBox txtSatUye, txtSatUrun, txtSatAdet;
        private System.Windows.Forms.Button btnSatis;

        private System.Windows.Forms.Label lblStokUrunId, lblStokAdet;
        private System.Windows.Forms.TextBox txtStokUrunId, txtStokAdet;
        private System.Windows.Forms.Button btnStokEkle;

        // Ders
        private System.Windows.Forms.Label lblDersProg, lblDersUye;
        private System.Windows.Forms.TextBox txtDersProg, txtDersUye;
        private System.Windows.Forms.Button btnKayit, btnKontenjan;

        // Finans
        private System.Windows.Forms.DateTimePicker dtpBas, dtpBit;
        private System.Windows.Forms.Button btnCiro, btnBorc, btnPasif;
        private System.Windows.Forms.Label lblCiroSonuc;
        private System.Windows.Forms.GroupBox grpBorcOde;
        private System.Windows.Forms.Label lblBorcUyeId, lblBorcMiktar;
        private System.Windows.Forms.TextBox txtBorcUyeId, txtBorcMiktar;
        private System.Windows.Forms.Button btnBorcOde;

        // Personel
        private System.Windows.Forms.Label lblPerAd, lblPerSoyad, lblPerPoz, lblPerMaas;
        private System.Windows.Forms.TextBox txtPerAd, txtPerSoyad, txtPerPoz, txtPerMaas;
        private System.Windows.Forms.DateTimePicker dtpPerTar;
        private System.Windows.Forms.Button btnPerEkle, btnPerSil;

        private System.Windows.Forms.Label lblVarPerId, lblVarGun, lblVarBas, lblVarBit;
        private System.Windows.Forms.TextBox txtVarPerId, txtVarBas, txtVarBit;
        private System.Windows.Forms.ComboBox cmbVarGun;
        private System.Windows.Forms.Button btnVarEkle, btnVarDuzenle;
    }
}