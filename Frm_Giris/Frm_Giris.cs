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
using System.Data.SqlClient;


namespace Frm_Giris
{
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void kayit_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_KayıtOl frmkayıtol = new Frm_KayıtOl();
            frmkayıtol.Show();
            this.Close();
        }

        private void sifremi_unuttum_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_SifremiUnuttum frmsifremiunuttum = new Frm_SifremiUnuttum();
            frmsifremiunuttum.Show();
            
        }

        private void pBoxSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == false)
            {
                pBoxSifreGoster.Image = Resources.kapali_kilit;
                txtSifre.UseSystemPasswordChar = true;
            }
            else 
            {
                pBoxSifreGoster.Image = Resources.acikKilit;
                txtSifre.UseSystemPasswordChar = false;
            }
        }


        #region Textboxlar için eventler 
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
            if (txtMail.ForeColor!=Color.Black)
            {
                txtMail.Text = null;
                txtMail.ForeColor = Color.Black;
            }
        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            txtMail.ForeColor = Color.Black;
        }
        #endregion

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Kullanici kul_giris = new Kullanici();
            if (kul_giris.girisYap(txtMail.Text, txtSifre.Text))
            {
                this.Close();
            }
            
            
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_hata_Click(object sender, EventArgs e)
        {
            Frm_HataGonderimi hataBildir = new Frm_HataGonderimi();
            hataBildir.Show();

        }

        private void pbox_geri_Click(object sender, EventArgs e)
        {
            Frm_Acilis acilis = new Frm_Acilis();
            acilis.Show();
            this.Close();    
        }

   
    }
}

