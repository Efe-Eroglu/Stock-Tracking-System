
namespace Frm_Giris
{
    partial class Frm_StokIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StokIslemleri));
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_islem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.urunMiktari = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.btn_geri = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.urun_id = new System.Windows.Forms.Label();
            this.urun_miktar = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_miktar
            // 
            this.txt_miktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_miktar.Location = new System.Drawing.Point(198, 264);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(189, 34);
            this.txt_miktar.TabIndex = 3;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.Color.Orange;
            this.btn_onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onayla.ForeColor = System.Drawing.Color.White;
            this.btn_onayla.Location = new System.Drawing.Point(529, 197);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(189, 52);
            this.btn_onayla.TabIndex = 4;
            this.btn_onayla.Text = "İşlem Yap";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "İşlem Türü :";
            // 
            // txt_islem
            // 
            this.txt_islem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_islem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_islem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_islem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_islem.FormattingEnabled = true;
            this.txt_islem.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.txt_islem.Location = new System.Drawing.Point(198, 188);
            this.txt_islem.Name = "txt_islem";
            this.txt_islem.Size = new System.Drawing.Size(189, 37);
            this.txt_islem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(26, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "İşlem Miktarı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ürün Adı :";
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_urunAd.Enabled = false;
            this.txt_urunAd.Location = new System.Drawing.Point(198, 112);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(339, 34);
            this.txt_urunAd.TabIndex = 1;
            // 
            // urunMiktari
            // 
            this.urunMiktari.AutoSize = true;
            this.urunMiktari.Location = new System.Drawing.Point(990, 49);
            this.urunMiktari.Name = "urunMiktari";
            this.urunMiktari.Size = new System.Drawing.Size(0, 29);
            this.urunMiktari.TabIndex = 35;
            this.urunMiktari.Visible = false;
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapatTuruncu;
            this.btn_kapat.Location = new System.Drawing.Point(868, 1);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 55);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 24;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Transparent;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.Image = global::Frm_Giris.Properties.Resources.geriTuruncu;
            this.btn_geri.Location = new System.Drawing.Point(2, 1);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(55, 55);
            this.btn_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_geri.TabIndex = 23;
            this.btn_geri.TabStop = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 412);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Location = new System.Drawing.Point(923, 748);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 29);
            this.lbl.TabIndex = 37;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbldate.Location = new System.Drawing.Point(404, 375);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 29);
            this.lbldate.TabIndex = 38;
            this.lbldate.Visible = false;
            // 
            // urun_id
            // 
            this.urun_id.AutoSize = true;
            this.urun_id.Location = new System.Drawing.Point(923, 241);
            this.urun_id.Name = "urun_id";
            this.urun_id.Size = new System.Drawing.Size(0, 29);
            this.urun_id.TabIndex = 33;
            this.urun_id.Visible = false;
            // 
            // urun_miktar
            // 
            this.urun_miktar.AutoSize = true;
            this.urun_miktar.Location = new System.Drawing.Point(923, 241);
            this.urun_miktar.Name = "urun_miktar";
            this.urun_miktar.Size = new System.Drawing.Size(0, 29);
            this.urun_miktar.TabIndex = 34;
            this.urun_miktar.Visible = false;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Orange;
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(529, 255);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(189, 52);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Ürünü Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Frm_StokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Frm_Giris.Properties.Resources.islem_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 778);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.urunMiktari);
            this.Controls.Add(this.urun_miktar);
            this.Controls.Add(this.urun_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_urunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_islem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_geri);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_StokIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_StokIslemleri";
            this.Load += new System.EventHandler(this.Frm_StokIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.PictureBox btn_geri;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_islem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.Label urunMiktari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label urun_id;
        private System.Windows.Forms.Label urun_miktar;
        private System.Windows.Forms.Button btn_sil;
    }
}