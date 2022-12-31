using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Giris
{
    public partial class Frm_Acilis : Form
    {
        public Frm_Acilis()
        {
            InitializeComponent();
        }

        private void Frm_Acilis_Load(object sender, EventArgs e)
        {

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            Frm_Giris kullanici_giris = new Frm_Giris();
            this.Hide();
            kullanici_giris.Show();
            
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Frm_AdminGiris admin_giris = new Frm_AdminGiris();
            admin_giris.Show();
            this.Hide();
        }

    }
}
