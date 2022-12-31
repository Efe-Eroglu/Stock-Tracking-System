
namespace Frm_Giris
{
    partial class Frm_AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdminPanel));
            this.btn_sikayet = new System.Windows.Forms.Button();
            this.btn_oneri = new System.Windows.Forms.Button();
            this.btn_kullanıcıGoruntule = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sikayet
            // 
            this.btn_sikayet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.btn_sikayet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sikayet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sikayet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sikayet.ForeColor = System.Drawing.Color.White;
            this.btn_sikayet.Location = new System.Drawing.Point(78, 341);
            this.btn_sikayet.Name = "btn_sikayet";
            this.btn_sikayet.Size = new System.Drawing.Size(296, 82);
            this.btn_sikayet.TabIndex = 1;
            this.btn_sikayet.Text = "Şikayetler";
            this.btn_sikayet.UseVisualStyleBackColor = false;
            this.btn_sikayet.Click += new System.EventHandler(this.btn_sikayet_Click);
            // 
            // btn_oneri
            // 
            this.btn_oneri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.btn_oneri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oneri.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oneri.ForeColor = System.Drawing.Color.White;
            this.btn_oneri.Location = new System.Drawing.Point(447, 341);
            this.btn_oneri.Name = "btn_oneri";
            this.btn_oneri.Size = new System.Drawing.Size(296, 82);
            this.btn_oneri.TabIndex = 2;
            this.btn_oneri.Text = "Öneriler";
            this.btn_oneri.UseVisualStyleBackColor = false;
            this.btn_oneri.Click += new System.EventHandler(this.btn_oneri_Click);
            // 
            // btn_kullanıcıGoruntule
            // 
            this.btn_kullanıcıGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btn_kullanıcıGoruntule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kullanıcıGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanıcıGoruntule.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanıcıGoruntule.ForeColor = System.Drawing.Color.White;
            this.btn_kullanıcıGoruntule.Location = new System.Drawing.Point(202, 487);
            this.btn_kullanıcıGoruntule.Name = "btn_kullanıcıGoruntule";
            this.btn_kullanıcıGoruntule.Size = new System.Drawing.Size(435, 82);
            this.btn_kullanıcıGoruntule.TabIndex = 3;
            this.btn_kullanıcıGoruntule.Text = "Kullanıcı Sil";
            this.btn_kullanıcıGoruntule.UseVisualStyleBackColor = false;
            this.btn_kullanıcıGoruntule.Click += new System.EventHandler(this.btn_kullanıcıGoruntule_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapama_ikonu;
            this.btn_kapat.Location = new System.Drawing.Point(1252, 2);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(59, 58);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 26;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Frm_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frm_Giris.Properties.Resources.admin_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 714);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_kullanıcıGoruntule);
            this.Controls.Add(this.btn_oneri);
            this.Controls.Add(this.btn_sikayet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdminPanel";
            this.Load += new System.EventHandler(this.Frm_AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sikayet;
        private System.Windows.Forms.Button btn_oneri;
        private System.Windows.Forms.Button btn_kullanıcıGoruntule;
        private System.Windows.Forms.PictureBox btn_kapat;
    }
}