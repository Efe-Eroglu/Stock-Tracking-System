using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Giris
{
    class IletiGonderme
    {

        SqlBaglanti bgl = new SqlBaglanti();

        public string konu { get; set; }
        public string metin { get; set; }
        public int gonderici_id { get; set; }

        public IletiGonderme(string konu,string metin,int gonderici_id=0)
        {
            this.konu = konu;
            this.metin = metin;
            this.gonderici_id = gonderici_id;
        }

        public void bildiriGonder(string sqlQuery, string mesaj)
        {
            try
            {
                SqlCommand komut = new SqlCommand(sqlQuery, bgl.baglanti());
                Kullanici kullanici = new Kullanici();
                komut.Parameters.AddWithValue("@p1", gonderici_id);
                komut.Parameters.AddWithValue("@p2", konu.ToUpper());
                komut.Parameters.AddWithValue("@p3", metin.ToUpper());
                komut.ExecuteNonQuery();
                MessageBox.Show(mesaj, "Hata Bildiriminiz Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Sunuculara ulaşmakta güçlük çekiyoruz lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt işlemi yapılırken bir hata ile karşılaşıldı lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                bgl.baglanti().Close();
            }

        }
    }
}
