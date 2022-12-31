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
    public partial class Frm_Rapor : Form
    {
        public Frm_Rapor()
        {
            InitializeComponent();
        }
        public int id_aktarim;
        SqlBaglanti bgl = new SqlBaglanti();
        private void btn_kapat_Click(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_AnaSayfa anasayfa = new Frm_AnaSayfa();
            anasayfa.id_aktarim = id_aktarim;
            anasayfa.Show();
            this.Hide();
        }

        DataSet1TableAdapters.DataTable4TableAdapter ds = new DataSet1TableAdapters.DataTable4TableAdapter();
        private void Frm_Rapor_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AllowUserToResizeRows = false;
            DateTime time = DateTime.Now;
            dtp_baslangic.Text = time.ToShortDateString();
            dtp_bitis.Text = time.ToShortDateString();
            dataGridView1.DataSource = ds.RaporGetir((short)id_aktarim,dtp_baslangic.Text, dtp_bitis.Text);
            dataGridView1.Columns["Miktar"].Width = 100;
            dataGridView1.Columns["İşlem"].Width = 200;
            renklendir();
            gridIslemleri();
        }

        void renklendir() 
        {

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {

                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ((dataGridView1.Rows[i].Cells["İşlem"].Value.ToString()).Equals("ÇIKIŞ"))
                {
                    renk.BackColor = Color.OrangeRed;
                }
                else
                {
                    renk.BackColor = Color.YellowGreen;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        void gridIslemleri()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.RaporGetir((short)id_aktarim, dtp_baslangic.Text, dtp_bitis.Text);
            renklendir();
        }

        private void btn_kapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
