using Frm_Giris.Properties;
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
    public partial class Frm_AdminGiris : Form
    {
        public Frm_AdminGiris()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if (admin.girisYap(txtMail.Text, txtSifre.Text))
            {
                this.Close();
            }
            //var admin = new AdminBuilder()
            //    .SetMail("admin@example.com")
            //    .SetSifre("123456")
            //    .Build();

            //bool girisBasarili = admin.GirisYap();

        }


        #region Texboxlar İçin Eventler
        void txtSifreEventi()
        {
            if (txtSifre.ForeColor != Color.Black)
            {

                txtSifre.Text = null;
                txtSifre.UseSystemPasswordChar = true;
                txtSifre.ForeColor = Color.Black;

            }

        }
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.ForeColor != Color.Black)
            {
                txtSifreEventi();
            }
        }
        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifreEventi();
        }
        private void txtMail_Click(object sender, EventArgs e)
        {
            if (txtMail.ForeColor != Color.Black)
            {
                txtMail.Text = null;
                txtMail.ForeColor = Color.Black;
            }
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtMail.ForeColor = Color.Black;
        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            txtMail.ForeColor = Color.Black;
        }
        #endregion

        private void Frm_AdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_Acilis acilis = new Frm_Acilis();
            acilis.Show();
            this.Hide();
        }

        private void sifre_goster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == false)
            {
                sifre_goster.Image = Resources.hideP;
                txtSifre.UseSystemPasswordChar = true;
            }
            else
            {
                sifre_goster.Image = Resources.showP;
                txtSifre.UseSystemPasswordChar = false;
            }
        }

  
    }
}
