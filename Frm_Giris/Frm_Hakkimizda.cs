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
    public partial class Frm_Hakkimizda : Form
    {
        public Frm_Hakkimizda()
        {
            InitializeComponent();
        }
        public int id_aktarim;
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void Frm_Hakkimizda_Load(object sender, EventArgs e)
        {

        }
    }
}
