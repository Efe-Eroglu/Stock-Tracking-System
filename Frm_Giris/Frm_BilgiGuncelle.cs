//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Frm_Giris
//{
//    public partial class Frm_BilgiGuncelle : Form
//    {
//        SqlBaglanti bgl = new SqlBaglanti();
//        public Frm_BilgiGuncelle()
//        {
//            InitializeComponent();
//        }

//        public int id_aktarim;
//        private void btn_kapat_Click(object sender, EventArgs e)
//        {
//            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

//            if (kapat == DialogResult.Yes)
//            {
//                Application.Exit();
//            }
//        }

//        private void Frm_BilgiGuncelle_Load(object sender, EventArgs e)
//        {

//            bilgileriGetir();
//        }

//        private void btn_guncelle_Click(object sender, EventArgs e)
//        {
//            Kullanici kullanici = new Kullanici(txtAd.Text,txtSoyad.Text,txtSifre.Text,txtEposta.Text,msktxtTelefon.Text,cmbSehir.Text,cmbCinsiyet.Text,txtTc.Text);
//            kullanici.Id =id_aktarim;
//            kullanici.bilgiGuncelle();
//        }

//        void bilgileriGetir()
//        {
//            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kullanici WHERE KULLANICI_ID="+id_aktarim,bgl.baglanti());
//            SqlDataReader dr = komut.ExecuteReader();

//            if (dr.Read()) 
//            {

//                txtAd.Text = dr["KULLANICI_ADI"].ToString();
//                txtSoyad.Text= dr["KULLANICI_SOYAD"].ToString();
//                txtEposta.Text = dr["KULLANICI_EPOSTA"].ToString();
//                txtSifre.Text = dr["KULLANICI_SIFRE"].ToString();
//                cmbCinsiyet.Text = dr["KULLANICI_CINSIYET"].ToString();
//                msktxtTelefon.Text= dr["KULLANICI_TELEFON"].ToString();
//                cmbSehir.Text= dr["KULLANICI_SEHIR"].ToString();
//                txtTc.Text = dr["KULLANICI_TC"].ToString();
//            }
//            bgl.baglanti().Close();

//        }

//        private void btn_geri_Click(object sender, EventArgs e)
//        {
//            Frm_AnaSayfa anasayfa = new Frm_AnaSayfa();
//            anasayfa.id_aktarim = id_aktarim;
//            anasayfa.Show();
//            this.Close();
//        }
//    }
//}

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
    public partial class Frm_BilgiGuncelle : Form
    {
        SqlBaglanti bgl = SqlBaglanti.Instance; // Singleton tasarımına uygun şekilde instance alınması
        public Frm_BilgiGuncelle()
        {
            InitializeComponent();
        }

        public int id_aktarim;
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Frm_BilgiGuncelle_Load(object sender, EventArgs e)
        {
            bilgileriGetir();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici(txtAd.Text, txtSoyad.Text, txtSifre.Text, txtEposta.Text, msktxtTelefon.Text, cmbSehir.Text, cmbCinsiyet.Text, txtTc.Text);
            kullanici.KullaniciId = id_aktarim;
            kullanici.bilgiGuncelle();
        }

        void bilgileriGetir()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kullanici WHERE KULLANICI_ID=" + id_aktarim, bgl.Baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txtAd.Text = dr["KULLANICI_ADI"].ToString();
                txtSoyad.Text = dr["KULLANICI_SOYAD"].ToString();
                txtEposta.Text = dr["KULLANICI_EPOSTA"].ToString();
                txtSifre.Text = dr["KULLANICI_SIFRE"].ToString();
                cmbCinsiyet.Text = dr["KULLANICI_CINSIYET"].ToString();
                msktxtTelefon.Text = dr["KULLANICI_TELEFON"].ToString();
                cmbSehir.Text = dr["KULLANICI_SEHIR"].ToString();
                txtTc.Text = dr["KULLANICI_TC"].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Frm_AnaSayfa anasayfa = new Frm_AnaSayfa();
            anasayfa.id_aktarim = id_aktarim;
            anasayfa.Show();
            this.Close();
        }
    }
}

