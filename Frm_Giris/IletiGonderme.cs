using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frm_Giris
{
    public interface IBildiriGondermeStrategy
    {
        void Gonder(SqlConnection connection, int gondericiId, string konu, string metin);
    }

    public class NormalBildiriGondermeStrategy : IBildiriGondermeStrategy
    {
        public void Gonder(SqlConnection connection, int gondericiId, string konu, string metin)
        {
            using (SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Sikayet(GONDERICI_ID,SIKAYET_BASLIK,SIKAYET_METIN) VALUES (@p1,@p2,@p3)", connection))
            {
                komut.Parameters.AddWithValue("@p1", gondericiId);
                komut.Parameters.AddWithValue("@p2", konu.ToUpper());
                komut.Parameters.AddWithValue("@p3", metin.ToUpper());
                komut.ExecuteNonQuery();
            }
        }
    }

    public class OncelikliBildiriGondermeStrategy : IBildiriGondermeStrategy
    {
        public void Gonder(SqlConnection connection, int gondericiId, string konu, string metin)
        {
            using (SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Sikayet(GONDERICI_ID,SIKAYET_BASLIK,SIKAYET_METIN) VALUES (@p1,@p2,@p3)", connection))
            {
                komut.Parameters.AddWithValue("@p1", gondericiId);
                komut.Parameters.AddWithValue("@p2", konu.ToUpper() + " [Öncelikli]");
                komut.Parameters.AddWithValue("@p3", metin.ToUpper());
                komut.ExecuteNonQuery();
            }
        }
    }

    public class IletiGonderme
    {
        private readonly SqlBaglanti _bgl = SqlBaglanti.Instance;

        public string Konu { get; set; }
        public string Metin { get; set; }
        public int GondericiId { get; set; }

        private IBildiriGondermeStrategy _bildiriGondermeStrategy;

        public IletiGonderme(string konu, string metin, int gondericiId = 0)
        {
            Konu = konu;
            Metin = metin;
            GondericiId = gondericiId;
        }

        public void SetBildiriGondermeStrategy(IBildiriGondermeStrategy strategy)
        {
            _bildiriGondermeStrategy = strategy;
        }

        public void Gonder()
        {
            try
            {
                using (SqlConnection connection = _bgl.Baglanti())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    _bildiriGondermeStrategy.Gonder(connection, GondericiId, Konu, Metin);

                    MessageBox.Show("Bildiri gönderme işlemi başarılı", "Bildiri Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Sunuculara ulaşmakta güçlük çekiyoruz lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt işlemi yapılırken bir hata ile karşılaşıldı lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
