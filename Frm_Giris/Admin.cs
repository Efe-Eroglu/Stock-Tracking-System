using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Giris
{
    class Admin
    {

        SqlBaglanti bgl = new SqlBaglanti();

        protected int id;
        protected string ad;
        protected string soyad;
        protected string sifre;
        protected string mail;

        public Admin()
        {

        }


        public virtual bool girisYap(string mail,string sifre)
        {
            string sqlQuery = "SELECT * FROM Tbl_Admin WHERE ADMIN_EPOSTA=@p1 AND ADMIN_SIFRE=@p2";
            try
            {

                SqlCommand komut = new SqlCommand(sqlQuery, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mail);
                komut.Parameters.AddWithValue("@p2", sifre);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["ADMIN_ID"]);
                    ad = dr["ADMIN_AD"].ToString();
                    soyad = dr["ADMIN_SOYAD"].ToString();

                    MessageBox.Show("Giriş başarılı admin paneline yönlendiriliyorsunuz.", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_AdminPanel panel = new Frm_AdminPanel();
                    panel.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Hatalı giriş bilgilerinizi kontrol ediniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            catch (SqlException)
            {
                MessageBox.Show("Sunuculara ulaşmakta güçlük çekiyoruz lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir hata ile karşılaşıldı lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                bgl.baglanti().Close();
            }
        }

        public void kullaniciSil(int k_id) 
        {
            try
            {
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Kullanici WHERE KULLANICI_ID=" + k_id, bgl.baglanti());
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla silindi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Sunuculara ulaşmakta güçlük çekiyoruz lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir hata ile karşılaşıldı lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                bgl.baglanti().Close();
            }





        }

     
    }
}
