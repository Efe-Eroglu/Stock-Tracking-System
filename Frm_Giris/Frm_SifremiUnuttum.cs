using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Giris
{
    public partial class Frm_SifremiUnuttum : Form
    {
        public Frm_SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void Frm_SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
        
    

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mailGonder_Click(object sender, EventArgs e)
        {
            Kullanici sifreDegis = new Kullanici();
            sifreDegis.mailAt(txtEposta.Text);
        }
    }
}
