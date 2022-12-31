
namespace Frm_Giris
{
    partial class Frm_HataGonderimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HataGonderimi));
            this.txtHataMetin = new System.Windows.Forms.RichTextBox();
            this.lbl_sayac = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.btn_hataGonder = new System.Windows.Forms.Button();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblMetin = new System.Windows.Forms.Label();
            this.cmbTercih = new System.Windows.Forms.ComboBox();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHataMetin
            // 
            this.txtHataMetin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHataMetin.Location = new System.Drawing.Point(80, 213);
            this.txtHataMetin.MaxLength = 600;
            this.txtHataMetin.Name = "txtHataMetin";
            this.txtHataMetin.Size = new System.Drawing.Size(612, 228);
            this.txtHataMetin.TabIndex = 3;
            this.txtHataMetin.Text = "";
            this.txtHataMetin.TextChanged += new System.EventHandler(this.txt_HataGonder_TextChanged);
            // 
            // lbl_sayac
            // 
            this.lbl_sayac.AutoSize = true;
            this.lbl_sayac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sayac.Location = new System.Drawing.Point(596, 444);
            this.lbl_sayac.Name = "lbl_sayac";
            this.lbl_sayac.Size = new System.Drawing.Size(72, 24);
            this.lbl_sayac.TabIndex = 1;
            this.lbl_sayac.Text = "Kalan : ";
            // 
            // txtKonu
            // 
            this.txtKonu.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Location = new System.Drawing.Point(80, 141);
            this.txtKonu.MaxLength = 100;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(340, 34);
            this.txtKonu.TabIndex = 1;
            // 
            // btn_hataGonder
            // 
            this.btn_hataGonder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hataGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hataGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hataGonder.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hataGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_hataGonder.Location = new System.Drawing.Point(269, 465);
            this.btn_hataGonder.Name = "btn_hataGonder";
            this.btn_hataGonder.Size = new System.Drawing.Size(220, 42);
            this.btn_hataGonder.TabIndex = 4;
            this.btn_hataGonder.Text = "GÖNDER";
            this.btn_hataGonder.UseVisualStyleBackColor = false;
            this.btn_hataGonder.Click += new System.EventHandler(this.btn_hataGonder_Click);
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.BackColor = System.Drawing.Color.Transparent;
            this.lblKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKonu.Location = new System.Drawing.Point(76, 113);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(154, 24);
            this.lblKonu.TabIndex = 4;
            this.lblKonu.Text = "Şikayet Konusu : ";
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.BackColor = System.Drawing.Color.Transparent;
            this.lblMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMetin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMetin.Location = new System.Drawing.Point(78, 190);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(134, 24);
            this.lblMetin.TabIndex = 5;
            this.lblMetin.Text = "Şikayet Metini :";
            // 
            // cmbTercih
            // 
            this.cmbTercih.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTercih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTercih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTercih.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTercih.FormattingEnabled = true;
            this.cmbTercih.Items.AddRange(new object[] {
            "Hata Bildirimi",
            "Öneri Bildirimi"});
            this.cmbTercih.Location = new System.Drawing.Point(509, 140);
            this.cmbTercih.Name = "cmbTercih";
            this.cmbTercih.Size = new System.Drawing.Size(183, 32);
            this.cmbTercih.TabIndex = 2;
            this.cmbTercih.SelectedIndexChanged += new System.EventHandler(this.cmbTercih_SelectedIndexChanged);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapama_ikonu;
            this.btn_kapat.Location = new System.Drawing.Point(720, 4);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 55);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 18;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(505, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hata - Öneri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.MaximumSize = new System.Drawing.Size(650, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 58);
            this.label2.TabIndex = 20;
            this.label2.Text = "Uygulamamızdaki hataları veya daha iyi olabileceğini düşündüğünüz konuları biziml" +
    "e paylaşabilirsiniz\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Frm_HataGonderimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.cmbTercih);
            this.Controls.Add(this.lblMetin);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.btn_hataGonder);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.lbl_sayac);
            this.Controls.Add(this.txtHataMetin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HataGonderimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HataGonderimi";
            this.Load += new System.EventHandler(this.Frm_HataGonderimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHataMetin;
        private System.Windows.Forms.Label lbl_sayac;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Button btn_hataGonder;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.ComboBox cmbTercih;
        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}