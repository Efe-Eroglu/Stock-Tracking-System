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
    public partial class Frm_UrunKarti : Form
    {
        public Frm_UrunKarti()
        {
            InitializeComponent();
        }
        public int id_aktarim;
        public int t_id;


        SqlBaglanti bgl = SqlBaglanti.Instance;
        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_AnaSayfa anasayfa = new Frm_AnaSayfa();
            anasayfa.id_aktarim = id_aktarim;
            anasayfa.Show();
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

        private void Frm_StokIslem_Load(object sender, EventArgs e)
        {
            tedarikciGetir();
            temizle();
        }

        #region Ara İşlemler
        void tedarikciGetir()
        {
            try
            {
                SqlCommand komut = new SqlCommand("SELECT TEDARIKCI_ISLETME FROM Tbl_Tedarikci WHERE KULLANICI_ID="+id_aktarim, bgl.Baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txt_tedarikci.Items.Add(dr["TEDARIKCI_ISLETME"].ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Bir hata oluştu lütfen daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally { bgl.Baglanti().Close(); }




        }

        private void txt_tedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string isletme = txt_tedarikci.Text;
                SqlCommand komut = new SqlCommand("SELECT TEDARIKCI_KATEGORI,TEDARIKCI_ID FROM Tbl_Tedarikci WHERE TEDARIKCI_ISLETME='" + isletme + "'", bgl.Baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    t_id = Convert.ToInt32(dr["TEDARIKCI_ID"]);
                    txt_kategori.Text = dr["TEDARIKCI_KATEGORI"].ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Bir hata oluştu lütfen daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally { bgl.Baglanti().Close(); }


        }
        void temizle()
        {
            txt_kategori.Clear();
            txt_marka.Clear();
            txt_urunAd.Clear();
            txt_urunAd.Focus();
            txt_tedarikci.Text =null;
            //dataGridView1.DataSource = ds.urunKarti((short)id_aktarim);
        }
        #endregion

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_urunAd.Text != "" & txt_marka.Text != "" & txt_tedarikci.Text != "")
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Urun(URUN_AD,URUN_KATEGORİ,URUN_MARKA,URUN_TEDARİKCİ_ID,URUN_KULLANICI_ID,URUN_MIKTAR) VALUES(@p1,@p2,@p3,@p4,@p5,0)", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", txt_urunAd.Text.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@p2", txt_kategori.Text.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@p3", txt_marka.Text.Trim().ToUpper());
                    komut.Parameters.AddWithValue("@p4", t_id);
                    komut.Parameters.AddWithValue("@p5", id_aktarim);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ürün kartı başarıyla eklendi.","İşlem başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    temizle();

                }
                else
                {
                    MessageBox.Show("Ürün bilgilerini doğru bir şekilde doldurduğunuzdan emin olun. ", "Uyarı ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Bir hata alındı lütfen daha sonra tekrar deneyin.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally { bgl.Baglanti().Close(); }
            
        }
    }
}
