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
    public partial class Frm_KayıtOl : Form
    {
        public Frm_KayıtOl()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();


        private void Frm_KayıtOl_Load(object sender, EventArgs e)
        { 
          
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (txtSifre.Text!= txtSifreTekrar.Text)
            {
                MessageBox.Show("Girilen şifreler birbirleri ile uyuşmamaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Kullanici kayitol = new Kullanici(txtAd.Text,txtSoyad.Text,txtSifre.Text,txtEposta.Text,msktxtTelefon.Text,cmbSehir.Text,cmbCinsiyet.Text,txtTc.Text);
                if (kayitol.kayitOl()) 
                {
                    Frm_Giris giris = new Frm_Giris();
                    giris.Show();
                    this.Close();
                }
            }
        }

        private void chckSozlesme_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSozlesme.Checked)
            {
                btnKayit.Enabled = true;
            }
            else
            {
                btnKayit.Enabled = false;
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

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_Giris giris = new Frm_Giris();
            giris.Show();
            this.Hide();
        }

        private void lbl_sozlesme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Sozlesme sozlesme = new Frm_Sozlesme();
            sozlesme.Show();
            
        }
    }
}
