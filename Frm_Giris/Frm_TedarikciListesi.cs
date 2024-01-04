using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Frm_Giris
{
    public partial class Frm_TedarikciListesi : Form
    {
        SqlBaglanti bgl = SqlBaglanti.Instance;
        public Frm_TedarikciListesi()
        {
            InitializeComponent();
        }
        


        public int id_aktarim;
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


        private void Frm_TedarikciListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToResizeRows = false;
            listele();
            gridIslemleri();
            dataGridView1.Columns["Id"].Width = 80;
        }


        #region Ara İşlemler Datagridview vb.
        void listele() 
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TEDARIKCI_ID AS Id ,TEDARIKCI_AD AS İsim ,TEDARIKCI_SOYAD AS Soyisim, TEDARIKCI_KATEGORI AS Kategori" +
                " ,TEDARIKCI_ISLETME AS İşletme,TEDARIKCI_EPOSTA AS Mail ,TEDARIKCI_TELEFON AS Telefon FROM Tbl_Tedarikci WHERE KULLANICI_ID ="+id_aktarim,bgl.Baglanti());

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.Baglanti().Close();
            txt_Ad.Clear();
            txt_isletme.Clear();
            txt_kategori.Clear();
            txt_mail.Clear();
            txt_soyad.Clear();
            txt_telefon.Clear();
            txt_Ad.Focus();
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
                string ad = dataGridView1.Rows[secili_alan].Cells["İsim"].Value.ToString();
                string soyad = dataGridView1.Rows[secili_alan].Cells["Soyisim"].Value.ToString();
                string kategori = dataGridView1.Rows[secili_alan].Cells["Kategori"].Value.ToString();
                string isletme = dataGridView1.Rows[secili_alan].Cells["İşletme"].Value.ToString();
                string mail = dataGridView1.Rows[secili_alan].Cells["Mail"].Value.ToString();
                string telefon = dataGridView1.Rows[secili_alan].Cells["Telefon"].Value.ToString();
                int t_id = Convert.ToInt32(dataGridView1.Rows[secili_alan].Cells["Id"].Value.ToString());
                txt_Ad.Text = ad;
                txt_isletme.Text = isletme;
                txt_kategori.Text = kategori;
                txt_mail.Text = mail;
                txt_soyad.Text = soyad;
                txt_telefon.Text = telefon;
                lblId.Text = t_id.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata alındı lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion 


        #region Ekleme Silme ve Güncelleme İşlemleri

        Kullanici kullanici = new Kullanici();
        
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            kullanici.KullaniciId = id_aktarim;
            kullanici.tedarikciEkle(txt_Ad.Text,txt_soyad.Text, txt_mail.Text, txt_telefon.Text, txt_kategori.Text, txt_isletme.Text);
            listele();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            
            kullanici.KullaniciId = id_aktarim;
            kullanici.tedarikciSil(Convert.ToInt32(lblId.Text));
            listele();

        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            kullanici.KullaniciId = id_aktarim;
            kullanici.tedarikciGuncelle(Convert.ToInt32(lblId.Text), txt_Ad.Text,txt_soyad.Text, txt_mail.Text, txt_telefon.Text, txt_kategori.Text, txt_isletme.Text);
            listele();

        }
        #endregion
        void gridIslemleri()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

    }
}
