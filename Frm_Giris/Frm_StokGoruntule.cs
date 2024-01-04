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
    public partial class Frm_StokGoruntule : Form
    {
        public Frm_StokGoruntule()
        {
            InitializeComponent();
        }
        public int id_aktarim;
        SqlBaglanti bgl = SqlBaglanti.Instance;
        private void Frm_StokGoruntule_Load(object sender, EventArgs e) {
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.DataSource = ds.Filtreleme(txt_filtre.Text, (short)id_aktarim);
            gridIslemleri();
        }


        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
       
        
        private void txt_filtre_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Filtreleme(txt_filtre.Text, (short)id_aktarim);
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbox_geri_Click(object sender, EventArgs e)
        {
            Frm_AnaSayfa anaSayfa = new Frm_AnaSayfa();
            anaSayfa.id_aktarim = id_aktarim;
            anaSayfa.Show();
            this.Close();
        }

        void gridIslemleri() 
        {
            dataGridView1.Columns["Miktar"].Width = 90;
            dataGridView1.Columns["Marka"].Width = 120;
            dataGridView1.Columns["Ürün Adı"].Width = 250;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
