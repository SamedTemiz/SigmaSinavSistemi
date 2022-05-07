
namespace SigmaSinavSistemi
{
    partial class KullaniciBilgiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgiGuncelle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BilgiGuncelle = new System.Windows.Forms.Button();
            this.linkLbl_Sifre = new System.Windows.Forms.LinkLabel();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lbl_Bilgi = new System.Windows.Forms.Label();
            this.data_bilgiGuncelleme = new System.Windows.Forms.DataGridView();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bilgiGuncelleme)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_BilgiGuncelle);
            this.panel1.Controls.Add(this.linkLbl_Sifre);
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.lbl_Bilgi);
            this.panel1.Controls.Add(this.data_bilgiGuncelleme);
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
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // btn_BilgiGuncelle
            // 
            this.btn_BilgiGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BilgiGuncelle.Location = new System.Drawing.Point(126, 299);
            this.btn_BilgiGuncelle.Name = "btn_BilgiGuncelle";
            this.btn_BilgiGuncelle.Size = new System.Drawing.Size(175, 29);
            this.btn_BilgiGuncelle.TabIndex = 104;
            this.btn_BilgiGuncelle.Text = "Bilgileri Güncelle";
            this.btn_BilgiGuncelle.UseVisualStyleBackColor = true;
            this.btn_BilgiGuncelle.Click += new System.EventHandler(this.btn_BilgiGuncelle_Click);
            // 
            // linkLbl_Sifre
            // 
            this.linkLbl_Sifre.AutoSize = true;
            this.linkLbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLbl_Sifre.Location = new System.Drawing.Point(17, 254);
            this.linkLbl_Sifre.Name = "linkLbl_Sifre";
            this.linkLbl_Sifre.Size = new System.Drawing.Size(367, 20);
            this.linkLbl_Sifre.TabIndex = 103;
            this.linkLbl_Sifre.TabStop = true;
            this.linkLbl_Sifre.Text = "Şifrenizi Güncellemek İsterseniz Bu Linke Tıklayınız.";
            this.linkLbl_Sifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_Sifre_LinkClicked);
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
            this.btn_cikis.TabIndex = 102;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lbl_Bilgi
            // 
            this.lbl_Bilgi.AutoSize = true;
            this.lbl_Bilgi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bilgi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bilgi.Location = new System.Drawing.Point(151, 30);
            this.lbl_Bilgi.Name = "lbl_Bilgi";
            this.lbl_Bilgi.Size = new System.Drawing.Size(150, 20);
            this.lbl_Bilgi.TabIndex = 101;
            this.lbl_Bilgi.Text = "Kullanıcı Bilgi Ekranı";
            // 
            // data_bilgiGuncelleme
            // 
            this.data_bilgiGuncelleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bilgiGuncelleme.Location = new System.Drawing.Point(52, 49);
            this.data_bilgiGuncelleme.Name = "data_bilgiGuncelleme";
            this.data_bilgiGuncelleme.RowHeadersWidth = 51;
            this.data_bilgiGuncelleme.RowTemplate.Height = 29;
            this.data_bilgiGuncelleme.Size = new System.Drawing.Size(28, 33);
            this.data_bilgiGuncelleme.TabIndex = 100;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(134, 207);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(216, 28);
            this.txt_mail.TabIndex = 95;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(134, 164);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.ReadOnly = true;
            this.txt_kulad.Size = new System.Drawing.Size(216, 27);
            this.txt_kulad.TabIndex = 94;
            // 
            // txt_soyad
            // 
            this.txt_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyad.Location = new System.Drawing.Point(134, 121);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(216, 27);
            this.txt_soyad.TabIndex = 93;
            // 
            // txt_ad
            // 
            this.txt_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ad.Location = new System.Drawing.Point(134, 78);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(216, 27);
            this.txt_ad.TabIndex = 92;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(19, 168);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.lbl_KullaniciAdi.TabIndex = 96;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mail.Location = new System.Drawing.Point(76, 211);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(43, 20);
            this.lbl_Mail.TabIndex = 97;
            this.lbl_Mail.Text = "Mail:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Soyad.Location = new System.Drawing.Point(64, 124);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(55, 20);
            this.lbl_Soyad.TabIndex = 98;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ad.Location = new System.Drawing.Point(86, 81);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 20);
            this.lbl_Ad.TabIndex = 99;
            this.lbl_Ad.Text = "Ad:";
            // 
            // KullaniciBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciBİlgiGuncelle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bilgiGuncelleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BilgiGuncelle;
        private System.Windows.Forms.LinkLabel linkLbl_Sifre;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_Bilgi;
        private System.Windows.Forms.DataGridView data_bilgiGuncelleme;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
    }
}