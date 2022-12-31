using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Giris
{
    public partial class Frm_SikayetOku : Form
    {
        public Frm_SikayetOku()
        {
            InitializeComponent();
        }

        public int sayac = 1;
        SqlBaglanti bgl = new SqlBaglanti();
        

       

        private void Frm_SikayetOku_Load(object sender, EventArgs e)
        {
            sikayetGetir(sayac);
        }
       
      
        public void sikayetGetir(int sayac)
        {
            try
            {

                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Sikayet WHERE SIKAYET_ID=" + sayac, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    txtID.Text = dr["GONDERICI_ID"].ToString();
                    txt_konu.Text = dr["SIKAYET_BASLIK"].ToString();
                    txt_metin.Text = dr["SIKAYET_METIN"].ToString();
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
            finally
            {
                bgl.baglanti().Close();
            }

        }
        void kontrol() 
        {
            
            try
            {
                
                SqlCommand komut = new SqlCommand("SELECT COUNT(SIKAYET_ID) FROM Tbl_Sikayet", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr[0]) < sayac)
                    {
                        MessageBox.Show("Tüm şikayetler bu kadar", "Şikayetler Sonlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sikayetGetir(sayac);
                    }
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
            finally
            {
                bgl.baglanti().Close();
            }
            
        }

        #region Tıklama İşlemleri
        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (sayac == 1) 
            {
                MessageBox.Show("İlk şikayet görüntülenmektedir daha geriye gidemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                sayac -= 1;
                kontrol();
            }
            
        }
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            sayac += 1;
            kontrol();
        }
        private void pbox_geri_Click(object sender, EventArgs e)
        {
            Frm_AdminPanel adminPanel = new Frm_AdminPanel();
            adminPanel.Show();
            this.Close();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}
