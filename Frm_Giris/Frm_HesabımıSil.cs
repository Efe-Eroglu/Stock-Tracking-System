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
    public partial class Frm_HesabımıSil : Form
    {
        public Frm_HesabımıSil()
        {
            InitializeComponent();
        }
        public int id_aktarim;


        private void txt_onay_TextChanged(object sender, EventArgs e)
        {

            txt_onay.ForeColor = Color.OrangeRed;
            if (txt_onay.Text == "ONAYLA")
            {
                btn_sil.Enabled = true;
            }
            else 
            {
                btn_sil.Enabled = false;
            }

        }
        private void txt_onay_Click(object sender, EventArgs e)
        {
            if (txt_onay.ForeColor != Color.OrangeRed)
            {

                txt_onay.Text = null;

                txt_onay.ForeColor = Color.Orange;

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if (kullanici.hesabımıKapat(id_aktarim) == true)
            {
                MessageBox.Show("Hesabınız kalıcı olarak silindi tekrar görüşmek üzere...","Hesap silme başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
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
            Frm_AnaSayfa anasayfa = new Frm_AnaSayfa();
            anasayfa.id_aktarim = id_aktarim;
            anasayfa.Show();
            this.Close();
            
        }

        private void Frm_HesabımıSil_Load(object sender, EventArgs e)
        {

        }

     
    }
}
