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
    public partial class Frm_HataGonderimi : Form
    {
        public Frm_HataGonderimi()
        {
            InitializeComponent();
        }

        private void Frm_HataGonderimi_Load(object sender, EventArgs e)
        {
            

        }

        public int gonderici_id;

        private void txt_HataGonder_TextChanged(object sender, EventArgs e)
        {
            int sayac = 600 - txtHataMetin.TextLength;
            lbl_sayac.Text = "Kalan :"+ sayac.ToString();
        }

        private void btn_hataGonder_Click(object sender, EventArgs e)
        {

            string sqlQuery;
            string mesaj;

            IletiGonderme ileti = new IletiGonderme(txtKonu.Text, txtHataMetin.Text, gonderici_id);

            if (cmbTercih.Text == "Hata Bildirimi")
            {
                ileti.SetBildiriGondermeStrategy(new NormalBildiriGondermeStrategy());
                ileti.Gonder();
            }
            else if (cmbTercih.Text == "")
            {
                MessageBox.Show("Şikayet/Öneri tercihi yapmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ileti.SetBildiriGondermeStrategy(new OncelikliBildiriGondermeStrategy());
                ileti.Gonder();
            }


        }

        private void cmbTercih_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbTercih.Text == "Hata Bildirimi")
            {
                lblKonu.Text = "Şikayet Konusu : ";
                lblMetin.Text = "Şikayet Metini : ";

            }

            else
            {
                lblKonu.Text = "Öneri Konusu :";
                lblMetin.Text = "Öneri Metini : ";
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
