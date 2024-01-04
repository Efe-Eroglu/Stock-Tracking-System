//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Frm_Giris
//{
//    public partial class Frm_KullaniciSil : Form
//    {
//        SqlBaglanti bgl = SqlBaglanti.Instance;

//        public Frm_KullaniciSil()
//        {
//            InitializeComponent();
//        }

//        private void cbox_uyarı_CheckedChanged(object sender, EventArgs e)
//        {
//            if (cbox_uyarı.Checked)
//            {
//                btn_sil.Enabled = true;
//            }
//            else 
//            {
//                btn_sil.Enabled = false;
//            }
//        }

//        private void btn_kapat_Click(object sender, EventArgs e)
//        {
//            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

//            if (kapat == DialogResult.Yes)
//            {
//                Application.Exit();
//            }
//        }

//        private void btn_geri_Click(object sender, EventArgs e)
//        {
//            Frm_AdminPanel adminPanel = new Frm_AdminPanel();
//            adminPanel.Show();
//            this.Close();
//        }

//        private void Frm_KullaniciSil_Load(object sender, EventArgs e)
//        {
//            listele();
//            gridIslemleri();
//        }

//        void listele()
//        {
//            SqlDataAdapter da = new SqlDataAdapter("SELECT KULLANICI_ID AS Id,KULLANICI_ADI +' '+KULLANICI_SOYAD AS İsim ,KULLANICI_EPOSTA AS Mail ," +
//                "KULLANICI_TELEFON AS Telefon FROM Tbl_Kullanici", bgl.baglanti());
//            DataSet ds = new DataSet();
//            da.Fill(ds);
//            dataGridView1.DataSource = ds.Tables[0];
//            txt_id.Clear();
//            txt_id.Focus();

//        }

//        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
//            int k_id = Convert.ToInt32(dataGridView1.Rows[secili_alan].Cells["Id"].Value.ToString());
//            txt_id.Text = k_id.ToString();
//        }

//        private void btn_sil_Click(object sender, EventArgs e)
//        {
//            Admin admin = new Admin();
//            admin.kullaniciSil(Convert.ToInt32(txt_id.Text));
//            listele();
//        }

//        void gridIslemleri()
//        {
//            dataGridView1.EnableHeadersVisualStyles = false;
//            dataGridView1.AllowUserToAddRows = false;
//            dataGridView1.RowHeadersVisible = false;
//            dataGridView1.Columns["Id"].Width = 90;
//        }




//    }
//}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frm_Giris
{
    public partial class Frm_KullaniciSil : Form
    {
        SqlBaglanti bgl = SqlBaglanti.Instance;

        public Frm_KullaniciSil()
        {
            InitializeComponent();
        }

        private void cbox_uyarı_CheckedChanged(object sender, EventArgs e)
        {
            btn_sil.Enabled = cbox_uyarı.Checked;
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_AdminPanel adminPanel = new Frm_AdminPanel();
            adminPanel.Show();
            this.Close();
        }

        private void Frm_KullaniciSil_Load(object sender, EventArgs e)
        {
            Listele();
            GridIslemleri();
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT KULLANICI_ID AS Id,KULLANICI_ADI +' '+KULLANICI_SOYAD AS İsim ," +
                "KULLANICI_EPOSTA AS Mail , KULLANICI_TELEFON AS Telefon FROM Tbl_Kullanici", bgl.Baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            txt_id.Clear();
            txt_id.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
            int k_id = Convert.ToInt32(dataGridView1.Rows[secili_alan].Cells["Id"].Value.ToString());
            txt_id.Text = k_id.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.kullaniciSil(Convert.ToInt32(txt_id.Text));
            Listele();
        }

        void GridIslemleri()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["Id"].Width = 90;
        }
    }
}

