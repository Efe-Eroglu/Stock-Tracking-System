
namespace Frm_Giris
{
    partial class Frm_SikayetOku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SikayetOku));
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.pbox_geri = new System.Windows.Forms.PictureBox();
            this.txt_metin = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_geri)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapama_ikonu;
            this.btn_kapat.Location = new System.Drawing.Point(731, 1);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 55);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 18;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // pbox_geri
            // 
            this.pbox_geri.BackColor = System.Drawing.Color.Transparent;
            this.pbox_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_geri.Image = global::Frm_Giris.Properties.Resources.icons8_back_67__3_;
            this.pbox_geri.Location = new System.Drawing.Point(1, 1);
            this.pbox_geri.Name = "pbox_geri";
            this.pbox_geri.Size = new System.Drawing.Size(55, 55);
            this.pbox_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_geri.TabIndex = 21;
            this.pbox_geri.TabStop = false;
            this.pbox_geri.Click += new System.EventHandler(this.pbox_geri_Click);
            // 
            // txt_metin
            // 
            this.txt_metin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_metin.Location = new System.Drawing.Point(72, 318);
            this.txt_metin.Name = "txt_metin";
            this.txt_metin.ReadOnly = true;
            this.txt_metin.Size = new System.Drawing.Size(641, 285);
            this.txt_metin.TabIndex = 3;
            this.txt_metin.Text = "";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(72, 119);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(211, 35);
            this.txtID.TabIndex = 1;
            // 
            // txt_konu
            // 
            this.txt_konu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_konu.Location = new System.Drawing.Point(72, 219);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.ReadOnly = true;
            this.txt_konu.Size = new System.Drawing.Size(373, 35);
            this.txt_konu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gönderici Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Şikayet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Konu :";
            // 
            // btn_ileri
            // 
            this.btn_ileri.BackColor = System.Drawing.Color.LightGray;
            this.btn_ileri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ileri.Location = new System.Drawing.Point(416, 620);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(156, 55);
            this.btn_ileri.TabIndex = 5;
            this.btn_ileri.Text = "İlerle";
            this.btn_ileri.UseVisualStyleBackColor = false;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.LightGray;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Location = new System.Drawing.Point(208, 620);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(156, 55);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Frm_SikayetOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Frm_Giris.Properties.Resources.sikayet_oku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 709);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_konu);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txt_metin);
            this.Controls.Add(this.pbox_geri);
            this.Controls.Add(this.btn_kapat);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_SikayetOku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SikayetOku";
            this.Load += new System.EventHandler(this.Frm_SikayetOku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.PictureBox pbox_geri;
        private System.Windows.Forms.RichTextBox txt_metin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}