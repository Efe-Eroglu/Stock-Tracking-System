
namespace Frm_Giris
{
    partial class Frm_SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SifremiUnuttum));
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btn_kapat = new System.Windows.Forms.PictureBox();
            this.btn_mailGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(208, 164);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(296, 35);
            this.txtEposta.TabIndex = 0;
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.Image = global::Frm_Giris.Properties.Resources.kapama_ikonu;
            this.btn_kapat.Location = new System.Drawing.Point(647, 0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(46, 47);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 20;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_mailGonder
            // 
            this.btn_mailGonder.BackgroundImage = global::Frm_Giris.Properties.Resources.mektup;
            this.btn_mailGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mailGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mailGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mailGonder.Location = new System.Drawing.Point(298, 306);
            this.btn_mailGonder.Name = "btn_mailGonder";
            this.btn_mailGonder.Size = new System.Drawing.Size(128, 86);
            this.btn_mailGonder.TabIndex = 21;
            this.btn_mailGonder.UseVisualStyleBackColor = true;
            this.btn_mailGonder.Click += new System.EventHandler(this.btn_mailGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 52);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 87);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aşağıda bulunan kutucuğa mail adresinizi yazarsanız size şifrenizi mail üzerinden" +
    " gönderebiliriz.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Frm_Giris.Properties.Resources.orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mailGonder);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.txtEposta);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SifremiUnuttum";
            this.Load += new System.EventHandler(this.Frm_SifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.PictureBox btn_kapat;
        private System.Windows.Forms.Button btn_mailGonder;
        private System.Windows.Forms.Label label1;
    }
}