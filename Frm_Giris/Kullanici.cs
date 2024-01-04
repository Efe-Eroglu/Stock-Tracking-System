using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Giris
{
    class Kullanici:Admin
    {
        SqlBaglanti bgl = SqlBaglanti.Instance;

   
        protected string telefon;
        private string sehir;
        private string cinsiyet;
        private string kimlik_numara;

        public int Id { get { return id; } set { id = value; } }
        

        public Kullanici()
        {

        }
        
        public Kullanici(string ad,string soyad,string sifre,string mail,string telefon,string sehir,string cinsiyet,string kimlik_numara)
        {
            this.ad = ad; this.soyad = soyad; this.sifre = sifre; this.mail = mail; this.telefon = telefon; this.sehir = sehir; this.cinsiyet = cinsiyet;this.kimlik_numara = kimlik_numara;
        }
      
        public override bool girisYap(string mail,string sifre)
        {
            string sqlQuery = "SELECT * FROM Tbl_Kullanici WHERE KULLANICI_EPOSTA=@p1 AND KULLANICI_SIFRE=@p2";
            try
            {

                SqlCommand komut = new SqlCommand(sqlQuery, bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", mail);
                komut.Parameters.AddWithValue("@p2", sifre);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["KULLANICI_ID"]);
                    ad = dr["KULLANICI_ADI"].ToString();
                    soyad = dr["KULLANICI_SOYAD"].ToString();
                    cinsiyet = dr["KULLANICI_CINSIYET"].ToString();
                    telefon = dr["KULLANICI_TELEFON"].ToString();
                    sehir = dr["KULLANICI_SEHIR"].ToString();
                    kimlik_numara = dr["KULLANICI_TC"].ToString();
                    MessageBox.Show("Giriş başarılı ana sayfaya yönlendiriliyorsunuz.", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_AnaSayfa anasayfa = new Frm_AnaSayfa();
                    anasayfa.id_aktarim = id;
                    anasayfa.Show();
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
                MessageBox.Show("Sunuculara ulaşmakta zorluk çekiyoruz lütfen tekrar deneyin.", "Sunucu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //HATANIN SEBEBİ SQLBAGLANTI CLASS INDAKI VERİ TABANI YOLUNUN GİRİLMEMİŞ OLMASI OLABİLİR
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                bgl.Baglanti().Close();
            }


        }

        public bool kayitOl()
        {

            SqlCommand komut3 = new SqlCommand("SELECT KULLANICI_ID FROM Tbl_Kullanici WHERE KULLANICI_TC=@p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", kimlik_numara);
            SqlDataReader dr2 = komut3.ExecuteReader();
            if (dr2.Read())
            {
                MessageBox.Show("Girilen Kimlik Numarası başka bir kullanıcı tarafından kullanılmaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                try
                {
                    if (ad == "" || soyad == "" || sifre == "" || mail == "" || kimlik_numara == "" ||
                    telefon == "(   )   -" || sehir == "" || cinsiyet == "")
                    {
                        MessageBox.Show("Bilgi alanlarının herhangi bir tanesi boş olamaz lütfen bilgilerinizi doldurunuz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        SqlCommand komut2 = new SqlCommand("SELECT KULLANICI_ID FROM Tbl_Kullanici WHERE KULLANICI_EPOSTA=@p1", bgl.Baglanti());
                        komut2.Parameters.AddWithValue("@p1", mail);
                        SqlDataReader dr = komut2.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Yazılan mail adresi başka bir kullanıcı tarafından kullanılmaktadır"
                                , "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {

                            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kullanici (KULLANICI_ADI,KULLANICI_SOYAD,KULLANICI_SIFRE,KULLANICI_EPOSTA,KULLANICI_TC," +
                                        "KULLANICI_TELEFON,KULLANICI_SEHIR,KULLANICI_CINSIYET) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.Baglanti());

                            komut.Parameters.AddWithValue("@p1", ad.Trim().ToUpper());
                            komut.Parameters.AddWithValue("@p2", soyad.Trim().ToUpper());
                            komut.Parameters.AddWithValue("@p3", sifre.Trim());
                            komut.Parameters.AddWithValue("@p4", mail.Trim());
                            komut.Parameters.AddWithValue("@p5", kimlik_numara.Trim());
                            komut.Parameters.AddWithValue("@p6", telefon.Trim());
                            komut.Parameters.AddWithValue("@p7", sehir.ToUpper());
                            komut.Parameters.AddWithValue("@p8", cinsiyet.ToUpper());
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kaydınız başarılı bir şekilde gerçekleştirildi giriş yapmak için sayfaya yönlendiriliyorsunuz", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;

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
                    MessageBox.Show("Kayıt işlemi yapılırken bir hata ile karşılaşıldı lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                finally
                {
                    bgl.Baglanti().Close();
                }

                
            }
        }

        public bool hesabımıKapat(int h_id)
        {   
            try
            {
                SqlCommand komut = new SqlCommand("DELETE Tbl_Kullanici WHERE KULLANICI_ID=" + h_id, bgl.Baglanti());
                komut.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                
                MessageBox.Show("Hesabınız silinirken bir hata oluştu hesabınız silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally 
            {
                bgl.Baglanti().Close();
            }
            

           

        }

        public void mailAt(string mailAdres)
        {
            
            MailMessage mailmsg = new MailMessage();
            SqlBaglanti bgl = SqlBaglanti.Instance;
            string from = "stockautomationsystem@gmail.com";
            
                SqlCommand komut = new SqlCommand("SELECT KULLANICI_SIFRE FROM Tbl_Kullanici WHERE KULLANICI_EPOSTA=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", mailAdres);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    sifre = dr["KULLANICI_SIFRE"].ToString();
                }
                if (sifre != null)
                {
                    mailmsg.To.Add(mailAdres);
                    mailmsg.Body = "Şifrenizi unuttuğunuzu belirttiniz, şifrenizi bu gönderinin altında bulabilir ve uygulamamızı kullanmaya devam edebilirsiniz. \n\n\n Şifreniz --> " + sifre;


                    SmtpClient istemci = new SmtpClient("smtp.gmail.com", 587);
                    istemci.DeliveryMethod = SmtpDeliveryMethod.Network;

                    mailmsg.From = new MailAddress(from);
                    mailmsg.Subject = "Şifre Hatırlatma İsteği";
                    istemci.EnableSsl = true;
                    istemci.Credentials = new NetworkCredential(from, "xshrtivkyumlbsbz");
                    istemci.Send(mailmsg);
                    MessageBox.Show("Şifreniz mail adresinize gönderildi.", "Mail gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı. Mail adresinizin doğruluğundan emin olun.", "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.Baglanti().Close();
        }

        public void bilgiGuncelle() 
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE Tbl_Kullanici SET KULLANICI_ADI=@p1,KULLANICI_SOYAD=@p2,KULLANICI_SIFRE=@p3,KULLANICI_EPOSTA=@p4,KULLANICI_TC=@p5," +
                                       "KULLANICI_TELEFON=@p6,KULLANICI_SEHIR=@p7,KULLANICI_CINSIYET=@p8 WHERE KULLANICI_ID="+id , bgl.Baglanti());

                komut.Parameters.AddWithValue("@p1", ad.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p2", soyad.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p3", sifre.Trim());
                komut.Parameters.AddWithValue("@p4", mail.Trim());
                komut.Parameters.AddWithValue("@p5", kimlik_numara.Trim());
                komut.Parameters.AddWithValue("@p6", telefon.Trim());
                komut.Parameters.AddWithValue("@p7", sehir.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p8", cinsiyet.ToUpper().Trim());
                komut.ExecuteNonQuery();
                
                MessageBox.Show("Bilgileriniz başarıyla güncellendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                bgl.Baglanti().Close();
            }
        }

        public void urunIslem(int miktar,int urun_id,char op) 
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE Tbl_Urun SET URUN_MIKTAR=URUN_MIKTAR" + op +" "+miktar + " WHERE URUN_KULLANICI_ID=@p2 AND URUN_ID=@p3", bgl.Baglanti());
                
                komut.Parameters.AddWithValue("@p2", Id);
                komut.Parameters.AddWithValue("@p3", urun_id);
                komut.ExecuteNonQuery();
                MessageBox.Show("İşleminiz başarıyla gerçekleştirildi.", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("İşleminiz sırasında bir hata ile karşılaşıldı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                bgl.Baglanti().Close();
            }
        }

        public void tedarikciEkle(string t_ad, string t_soyad, string t_mail, string t_telefon, string t_kategori, string t_isletme) 
        {
            try
            {

                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Tedarikci(TEDARIKCI_AD,TEDARIKCI_SOYAD,TEDARIKCI_KATEGORI,TEDARIKCI_TELEFON," +
                    "TEDARIKCI_ISLETME,TEDARIKCI_EPOSTA,KULLANICI_ID) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", t_ad.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p2", t_soyad.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p3", t_kategori.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p4", t_telefon.Trim());
                komut.Parameters.AddWithValue("@p5", t_isletme.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p6", t_mail.Trim());
                komut.Parameters.AddWithValue("@p7", id);
                komut.ExecuteNonQuery();
                MessageBox.Show("Tedarikci başarıyla eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public void tedarikciSil(int t_id) 
        {

            {
                try
                {
                    SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Tedarikci WHERE TEDARIKCI_ID=" + t_id, bgl.Baglanti());
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Tedarikci başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    bgl.Baglanti().Close();
                }
            }
        }
        public void tedarikciGuncelle(int t_id, string t_ad, string t_soyad, string t_mail, string t_telefon, string t_kategori, string t_isletme) 
        {

            {
                try
                {
                    SqlCommand komut = new SqlCommand("UPDATE Tbl_Tedarikci SET TEDARIKCI_AD=@p1,TEDARIKCI_SOYAD=@p2,TEDARIKCI_KATEGORI=@p3," +
                        "TEDARIKCI_TELEFON=@p4,TEDARIKCI_ISLETME=@p5," + "TEDARIKCI_EPOSTA=@p6 WHERE TEDARIKCI_ID=" + t_id, bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", t_ad.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@p2", t_soyad.ToUpper().Trim());
                    komut.Parameters.AddWithValue("@p3", t_kategori.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@p4", t_telefon.Trim());
                    komut.Parameters.AddWithValue("@p5", t_isletme.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@p6", t_mail.Trim());
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Tedarikci başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    bgl.Baglanti().Close();
                }

            }
        }
        
    }
}
