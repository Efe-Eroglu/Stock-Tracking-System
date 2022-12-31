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
    public partial class Frm_OneriOku : Form
    {
        public Frm_OneriOku()
        {
            InitializeComponent();
        }
        public int sayac = 1;
        SqlBaglanti bgl = new SqlBaglanti();
        private void Frm_OneriOku_Load(object sender, EventArgs e)
        {
            oneriGetir(sayac);
        }

        public void oneriGetir(int sayac)
        {
            try
            {

                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Oneri WHERE ONERI_ID=" + sayac, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    txtID.Text = dr["GONDERICI_ID"].ToString();
                    txt_konu.Text = dr["ONERI_BASLIK"].ToString();
                    txt_metin.Text = dr["ONERI_METIN"].ToString();
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
                bgl.baglanti().Close();
            }

        }
        void kontrol()
        {

            try
            {

                SqlCommand komut = new SqlCommand("SELECT COUNT(ONERI_ID) FROM Tbl_Oneri", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr[0]) < sayac)
                    {
                        MessageBox.Show("Tüm öneriler bu kadar", "Öneriler Sonlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        oneriGetir(sayac);
                    }
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
                bgl.baglanti().Close();
            }

        }

        #region İleti hareketleri
        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                MessageBox.Show("İlk öneri görüntülenmektedir daha geriye gidemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        #endregion

        private void btn_geri2_Click(object sender, EventArgs e)
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
    }
}
