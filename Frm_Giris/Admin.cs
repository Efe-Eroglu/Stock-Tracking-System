using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frm_Giris
{
    public class Admin
    {
        private readonly SqlBaglanti bgl = SqlBaglanti.Instance;

        protected int id { get; private set; }
        public string Ad { get; private set; }
        public string Soyad { get; private set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }

        public Admin() { }

        public virtual bool girisYap(string mail, string sifre)
        {
            string sqlQuery = "SELECT * FROM Tbl_Admin WHERE ADMIN_EPOSTA=@p1 AND ADMIN_SIFRE=@p2";

            try
            {
                using (SqlCommand komut = new SqlCommand(sqlQuery, bgl.Baglanti()))
                {
                    komut.Parameters.AddWithValue("@p1", mail);
                    komut.Parameters.AddWithValue("@p2", sifre);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            id = Convert.ToInt32(dr["ADMIN_ID"]);
                            Ad = dr["ADMIN_AD"].ToString();
                            Soyad = dr["ADMIN_SOYAD"].ToString();

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
                bgl.Baglanti().Close();
            }
        }

        public void KullaniciSil(int k_id)
        {
            try
            {
                using (SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Kullanici WHERE KULLANICI_ID=" + k_id, bgl.Baglanti()))
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarıyla silindi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                bgl.Baglanti().Close();
            }
        }
    }

    public class AdminDirector
    {
        private readonly IAdminBuilder adminBuilder;

        public AdminDirector(IAdminBuilder builder)
        {
            adminBuilder = builder;
        }

        public void Construct(string mail, string sifre)
        {
            adminBuilder.SetMail(mail);
            adminBuilder.SetSifre(sifre);
            adminBuilder.Build();
        }
    }

    public interface IAdminBuilder
    {
        void SetMail(string mail);
        void SetSifre(string sifre);
        void Build();
    }

    public class AdminBuilder : IAdminBuilder
    {
        private readonly Admin admin;

        public AdminBuilder()
        {
            admin = new Admin();
        }

        public void SetMail(string mail)
        {
            admin.Mail = mail;
        }

        public void SetSifre(string sifre)
        {
            admin.Sifre = sifre;
        }

        public void Build()
        {
            admin.girisYap(admin.Mail, admin.Sifre);
        }

        public Admin GetAdmin()
        {
            return admin;
        }
    }
}
