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
    public partial class Frm_AdminPanel : Form
    {
        public Frm_AdminPanel()
        {
            InitializeComponent();
        }

        private void Frm_AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_sikayet_Click(object sender, EventArgs e)
        {
            Frm_SikayetOku sikayetOku = new Frm_SikayetOku();
            sikayetOku.Show();
            this.Close();
        }

        private void btn_oneri_Click(object sender, EventArgs e)
        {
            Frm_OneriOku oneriOku = new Frm_OneriOku();
            oneriOku.Show();
            this.Close();

        }

        private void btn_kullanıcıGoruntule_Click(object sender, EventArgs e)
        {
            Frm_KullaniciSil kullaniciSil = new Frm_KullaniciSil();
            kullaniciSil.Show();
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
    }
}
