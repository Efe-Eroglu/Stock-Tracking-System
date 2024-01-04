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
    public partial class Frm_StokIslemleri : Form
    {
        public Frm_StokIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = SqlBaglanti.Instance;
        public int id_aktarim;
        public string secim="";

        DateTime time=DateTime.Now;
        public string zaman;
        private void Frm_StokIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToResizeRows = false;
            zaman = time.Year+"-"+time.Month + "-" + time.Day;
            dataGridView1.DataSource = ds.UrunMiktarlari((short)id_aktarim);
            gridIslemleri();
            dataGridView1.Columns["Id"].Width = 60;
            dataGridView1.Columns["Miktar"].Width = 80;
            
        }

        
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_AnaSayfa anaSayfa = new Frm_AnaSayfa();
            anaSayfa.id_aktarim = id_aktarim;
            anaSayfa.Show();
            this.Close();
        }

        DataSet1TableAdapters.DataTable3TableAdapter ds = new DataSet1TableAdapters.DataTable3TableAdapter();

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            
            Kullanici kullanici = new Kullanici();
            
            if (txt_miktar.Text != "" && txt_islem.Text != "")
            {
                if (txt_islem.SelectedIndex == 0)
                {
                    secim = "Giriş";
                    kullanici.KullaniciId = id_aktarim;
                    kullanici.urunIslem(Convert.ToInt32(txt_miktar.Text), Convert.ToInt32(urun_id.Text),'+');
                    islemKayit();
                    temizle();
                }
                else
                {
                    if (Convert.ToInt32(urunMiktari.Text) - Convert.ToInt32(txt_miktar.Text) >= 0)
                    {
                        secim = "Çıkış";
                        kullanici.KullaniciId = id_aktarim;
                        kullanici.urunIslem(Convert.ToInt32(txt_miktar.Text), Convert.ToInt32(urun_id.Text), '-');
                        islemKayit();
                        temizle();
                    }
                    else 
                    {
                        MessageBox.Show("Girilen değer ürün stoğunun üzerindedir bu miktarda ürün çıkışı yapılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Lütfen gerekli kutucukları doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void temizle() 
        {
            dataGridView1.DataSource = ds.UrunMiktarlari((short)id_aktarim);
            txt_islem.Text = null;
            txt_miktar.Clear();
            txt_urunAd.Clear();
            urun_id.Text = null;
        }
        void islemKayit() 
        {

            try
            {

                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Islem(ISLEM_TUR,ISLEM_MIKTAR,ISLEM_URUN_ID,KULLANICI_ID,ISLEM_TARIH) VALUES(@p1,@p2,@p3,@p4,@p5)", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p2", txt_miktar.Text);
                komut.Parameters.AddWithValue("@p3", urun_id.Text);
                komut.Parameters.AddWithValue("@p1", secim.ToUpper().Trim());
                komut.Parameters.AddWithValue("@p4", id_aktarim);
                komut.Parameters.AddWithValue("@p5", zaman);
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.Baglanti().Close();
            }


        }

        void gridIslemleri()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secili_alan].Cells["Ürün"].Value.ToString();
            int idUrun = Convert.ToInt32(dataGridView1.Rows[secili_alan].Cells["Id"].Value.ToString());
            int urun_miktar = Convert.ToInt32(dataGridView1.Rows[secili_alan].Cells["Miktar"].Value.ToString());
            urun_id.Text = idUrun.ToString();
            urunMiktari.Text = urun_miktar.ToString();
            txt_urunAd.Text = ad;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (urun_id.Text != "")
                {
                    SqlCommand komut = new SqlCommand("DELETE Tbl_Urun WHERE URUN_ID=@p1 AND URUN_KULLANICI_ID = @p2", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", urun_id.Text);
                    komut.Parameters.AddWithValue("@p2", id_aktarim);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Seçilen ürün başarıyla silindi.", "Ürün silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                else
                {
                    MessageBox.Show("Ürün seçilmeden silme işlemi yapılamaz lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı lütfen daha sonra tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally 
            {
                bgl.Baglanti().Close();
            }
            


        }
    }
}
