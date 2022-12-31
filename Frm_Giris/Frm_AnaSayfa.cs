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
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }

        public int id_aktarim;
        
        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        

        private void pbox_kapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Uygulamayı kapatmak istediğinizden eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pbox_hata_Click(object sender, EventArgs e)
        {
            Frm_HataGonderimi hataGonder = new Frm_HataGonderimi();
            hataGonder.gonderici_id = id_aktarim;
            hataGonder.Show();
        }
        
        private void btn_ted_list_Click(object sender, EventArgs e)
        {
            Frm_TedarikciListesi ted_liste = new Frm_TedarikciListesi();
            ted_liste.id_aktarim = id_aktarim;
            ted_liste.Show();
            this.Close();
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            Frm_StokIslemleri stok = new Frm_StokIslemleri();
            stok.id_aktarim = id_aktarim;
            stok.Show();
            this.Close();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            Frm_Rapor rapor = new Frm_Rapor();
            rapor.id_aktarim = id_aktarim;
            rapor.Show();
            
        }

        private void btn_hakkimizda_Click(object sender, EventArgs e)
        {
            Frm_Hakkimizda hakkimizda = new Frm_Hakkimizda();
            hakkimizda.id_aktarim = id_aktarim;
            hakkimizda.Show();
            
        }
        
        
        int sayac = 0;
        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            sayac++;

            if (sayac % 2 != 0)
            {
                btn_bilgiGuncelle.Visible = true;
                btn_hesapSil.Visible = true;
            }
            else 
            {
                btn_bilgiGuncelle.Visible = false;
                btn_hesapSil.Visible = false;
            }

        }

        private void btn_stok_goruntule_Click(object sender, EventArgs e)
        {
            Frm_StokGoruntule stokGoruntule = new Frm_StokGoruntule();
            stokGoruntule.id_aktarim = id_aktarim;
            stokGoruntule.Show();
            this.Close();
            
        }

        private void btn_urun_kartı_Click(object sender, EventArgs e)
        {
            Frm_UrunKarti urunKarti = new Frm_UrunKarti();
            urunKarti.id_aktarim = id_aktarim;
            urunKarti.Show();
            this.Close();
        }
      

        private void btn_bilgiGuncelle_Click(object sender, EventArgs e)
        {
            Frm_BilgiGuncelle bilgiGuncelle = new Frm_BilgiGuncelle();
            bilgiGuncelle.id_aktarim = id_aktarim;
            bilgiGuncelle.Show();
            this.Close();
        }

        private void btn_hesapSil_Click(object sender, EventArgs e)
        {
            Frm_HesabımıSil hesabımıSil = new Frm_HesabımıSil();
            hesabımıSil.id_aktarim = id_aktarim;
            hesabımıSil.Show();
            this.Close();
        }
    }
}
