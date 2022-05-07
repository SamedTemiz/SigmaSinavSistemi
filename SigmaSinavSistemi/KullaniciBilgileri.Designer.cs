
namespace SigmaSinavSistemi
{
    partial class KullaniciBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgileri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lbl_Bilgi = new System.Windows.Forms.Label();
            this.data_bilgi = new System.Windows.Forms.DataGridView();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.lbl_Bilgi);
            this.panel1.Controls.Add(this.data_bilgi);
            this.panel1.Controls.Add(this.txt_mail);
            this.panel1.Controls.Add(this.txt_kulad);
            this.panel1.Controls.Add(this.txt_soyad);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.lbl_KullaniciAdi);
            this.panel1.Controls.Add(this.lbl_Mail);
            this.panel1.Controls.Add(this.lbl_Soyad);
            this.panel1.Controls.Add(this.lbl_Ad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 300);
            this.panel1.TabIndex = 0;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cikis.Location = new System.Drawing.Point(357, 13);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(30, 30);
            this.btn_cikis.TabIndex = 78;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lbl_Bilgi
            // 
            this.lbl_Bilgi.AutoSize = true;
            this.lbl_Bilgi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bilgi.Location = new System.Drawing.Point(126, 20);
            this.lbl_Bilgi.Name = "lbl_Bilgi";
            this.lbl_Bilgi.Size = new System.Drawing.Size(150, 20);
            this.lbl_Bilgi.TabIndex = 77;
            this.lbl_Bilgi.Text = "Kullanıcı Bilgi Ekranı";
            // 
            // data_bilgi
            // 
            this.data_bilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bilgi.Location = new System.Drawing.Point(332, 229);
            this.data_bilgi.Name = "data_bilgi";
            this.data_bilgi.RowHeadersWidth = 51;
            this.data_bilgi.RowTemplate.Height = 29;
            this.data_bilgi.Size = new System.Drawing.Size(28, 33);
            this.data_bilgi.TabIndex = 76;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(144, 195);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.ReadOnly = true;
            this.txt_mail.Size = new System.Drawing.Size(216, 28);
            this.txt_mail.TabIndex = 69;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(144, 152);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.ReadOnly = true;
            this.txt_kulad.Size = new System.Drawing.Size(216, 27);
            this.txt_kulad.TabIndex = 68;
            // 
            // txt_soyad
            // 
            this.txt_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyad.Location = new System.Drawing.Point(144, 109);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(216, 27);
            this.txt_soyad.TabIndex = 67;
            // 
            // txt_ad
            // 
            this.txt_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ad.Location = new System.Drawing.Point(144, 66);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(216, 27);
            this.txt_ad.TabIndex = 66;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(29, 156);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.lbl_KullaniciAdi.TabIndex = 70;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mail.Location = new System.Drawing.Point(86, 199);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(43, 20);
            this.lbl_Mail.TabIndex = 71;
            this.lbl_Mail.Text = "Mail:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Soyad.Location = new System.Drawing.Point(74, 112);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(55, 20);
            this.lbl_Soyad.TabIndex = 72;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ad.Location = new System.Drawing.Point(96, 69);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 20);
            this.lbl_Ad.TabIndex = 73;
            this.lbl_Ad.Text = "Ad:";
            // 
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bilgi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.DataGridView data_bilgi;
        private System.Windows.Forms.Label lbl_Bilgi;
        private System.Windows.Forms.Button btn_cikis;
    }
}