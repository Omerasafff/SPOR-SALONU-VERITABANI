using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace VTYS
{
    public class Veritabani
    {
        // ⚠️ DİKKAT: 'SIFRENI_YAZ' yerine kendi pgAdmin şifrenizi girin.
        private static string baglantiAdresi = "Host=localhost;Username=postgres;Password=123;Database=SporSalonuDB";

        public static NpgsqlConnection BaglantiGetir()
        {
            return new NpgsqlConnection(baglantiAdresi);
        }

        public static DataTable VeriGetir(string sql)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection baglanti = BaglantiGetir())
            {
                try
                {
                    baglanti.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, baglanti))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri Getirme Hatası: " + ex.Message);
                }
            }
            return dt;
        }

        public static bool KomutCalistir(NpgsqlCommand komut)
        {
            using (NpgsqlConnection baglanti = BaglantiGetir())
            {
                try
                {
                    komut.Connection = baglanti;
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    return true;
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show("İşlem Başarısız: " + ex.MessageText);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem Hatası: " + ex.Message);
                    return false;
                }
            }
        }
    }
}