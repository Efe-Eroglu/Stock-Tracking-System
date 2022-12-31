
namespace Frm_Giris
{
    partial class Frm_UrunKarti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UrunKarti));
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.btn_geri = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tedarikci = new System.Windows.Forms.ComboBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapatTuruncu;
            this.btn_kapat.Location = new System.Drawing.Point(964, 1);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 55);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 18;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Transparent;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.Image = global::Frm_Giris.Properties.Resources.geriTuruncu;
            this.btn_geri.Location = new System.Drawing.Point(384, 1);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(55, 55);
            this.btn_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_geri.TabIndex = 21;
            this.btn_geri.TabStop = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(493, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ürün Adı :";
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_urunAd.Location = new System.Drawing.Point(664, 128);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(247, 35);
            this.txt_urunAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(493, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kategori :";
            // 
            // txt_kategori
            // 
            this.txt_kategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_kategori.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_kategori.Enabled = false;
            this.txt_kategori.Location = new System.Drawing.Point(664, 394);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(247, 35);
            this.txt_kategori.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(515, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Marka :";
            // 
            // txt_marka
            // 
            this.txt_marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_marka.Location = new System.Drawing.Point(664, 219);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(247, 35);
            this.txt_marka.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(493, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tedarikci :";
            // 
            // txt_tedarikci
            // 
            this.txt_tedarikci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_tedarikci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_tedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_tedarikci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_tedarikci.FormattingEnabled = true;
            this.txt_tedarikci.Location = new System.Drawing.Point(664, 300);
            this.txt_tedarikci.Name = "txt_tedarikci";
            this.txt_tedarikci.Size = new System.Drawing.Size(247, 36);
            this.txt_tedarikci.TabIndex = 3;
            this.txt_tedarikci.SelectedIndexChanged += new System.EventHandler(this.txt_tedarikci_SelectedIndexChanged);
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onayla.ForeColor = System.Drawing.Color.White;
            this.btn_onayla.Location = new System.Drawing.Point(606, 521);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(245, 51);
            this.btn_onayla.TabIndex = 5;
            this.btn_onayla.Text = "Ekle";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(590, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 40);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ürün Kartı Ekleme";
            // 
            // Frm_UrunKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Frm_Giris.Properties.Resources.kart;
            this.ClientSize = new System.Drawing.Size(1021, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.txt_tedarikci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_urunAd);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kapat);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_UrunKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_StokIslem";
            this.Load += new System.EventHandler(this.Frm_StokIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.PictureBox btn_geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_tedarikci;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Label label5;
    }
}