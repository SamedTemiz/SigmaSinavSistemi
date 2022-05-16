
namespace SigmaSinavSistemi
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.combo_kullanici = new System.Windows.Forms.ComboBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_sifreonay = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciTip = new System.Windows.Forms.Label();
            this.lbl_SifreOnay = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.cmb_uzanti = new System.Windows.Forms.ComboBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_kullanici
            // 
            this.combo_kullanici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combo_kullanici.FormattingEnabled = true;
            this.combo_kullanici.Items.AddRange(new object[] {
            "Öğrenci",
            "Admin",
            "Sınav Sorumlusu"});
            this.combo_kullanici.Location = new System.Drawing.Point(450, 390);
            this.combo_kullanici.Name = "combo_kullanici";
            this.combo_kullanici.Size = new System.Drawing.Size(151, 28);
            this.combo_kullanici.TabIndex = 8;
            this.combo_kullanici.Text = "--Seçin--";
            // 
            // btn_kayit
            // 
            this.btn_kayit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kayit.Location = new System.Drawing.Point(450, 433);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(152, 44);
            this.btn_kayit.TabIndex = 9;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_sifreonay
            // 
            this.txt_sifreonay.Location = new System.Drawing.Point(450, 347);
            this.txt_sifreonay.Name = "txt_sifreonay";
            this.txt_sifreonay.PasswordChar = '*';
            this.txt_sifreonay.PlaceholderText = "Şifre Onay";
            this.txt_sifreonay.Size = new System.Drawing.Size(151, 27);
            this.txt_sifreonay.TabIndex = 7;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(450, 304);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.PlaceholderText = "Şifre";
            this.txt_sifre.Size = new System.Drawing.Size(151, 27);
            this.txt_sifre.TabIndex = 6;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(450, 260);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.PlaceholderText = "Mail";
            this.txt_mail.Size = new System.Drawing.Size(151, 28);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(450, 217);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.PlaceholderText = "Kullanıcı Ad";
            this.txt_kulad.Size = new System.Drawing.Size(151, 27);
            this.txt_kulad.TabIndex = 3;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(450, 174);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.PlaceholderText = "Soyad";
            this.txt_soyad.Size = new System.Drawing.Size(151, 27);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(450, 131);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.PlaceholderText = "Ad";
            this.txt_ad.Size = new System.Drawing.Size(151, 27);
            this.txt_ad.TabIndex = 1;
            // 
            // lbl_KullaniciTip
            // 
            this.lbl_KullaniciTip.AutoSize = true;
            this.lbl_KullaniciTip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KullaniciTip.Location = new System.Drawing.Point(333, 393);
            this.lbl_KullaniciTip.Name = "lbl_KullaniciTip";
            this.lbl_KullaniciTip.Size = new System.Drawing.Size(102, 20);
            this.lbl_KullaniciTip.TabIndex = 4;
            this.lbl_KullaniciTip.Text = "Kullanıcı Tipi:";
            // 
            // lbl_SifreOnay
            // 
            this.lbl_SifreOnay.AutoSize = true;
            this.lbl_SifreOnay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SifreOnay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SifreOnay.Location = new System.Drawing.Point(350, 349);
            this.lbl_SifreOnay.Name = "lbl_SifreOnay";
            this.lbl_SifreOnay.Size = new System.Drawing.Size(85, 20);
            this.lbl_SifreOnay.TabIndex = 5;
            this.lbl_SifreOnay.Text = "Şifre Onay:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sifre.Location = new System.Drawing.Point(388, 305);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(45, 20);
            this.lbl_Sifre.TabIndex = 6;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(335, 219);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.lbl_KullaniciAdi.TabIndex = 7;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mail.Location = new System.Drawing.Point(389, 262);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(43, 20);
            this.lbl_Mail.TabIndex = 8;
            this.lbl_Mail.Text = "Mail:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Soyad.Location = new System.Drawing.Point(377, 175);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(55, 20);
            this.lbl_Soyad.TabIndex = 9;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ad.Location = new System.Drawing.Point(399, 132);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(33, 20);
            this.lbl_Ad.TabIndex = 10;
            this.lbl_Ad.Text = "Ad:";
            // 
            // cmb_uzanti
            // 
            this.cmb_uzanti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_uzanti.FormattingEnabled = true;
            this.cmb_uzanti.Items.AddRange(new object[] {
            "@sigmatematik.com",
            "@hotmail.com",
            "@outlook.com",
            "@gmail.com"});
            this.cmb_uzanti.Location = new System.Drawing.Point(600, 260);
            this.cmb_uzanti.Name = "cmb_uzanti";
            this.cmb_uzanti.Size = new System.Drawing.Size(180, 28);
            this.cmb_uzanti.TabIndex = 5;
            this.cmb_uzanti.Text = "@sigmatematik.com";
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.White;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.Location = new System.Drawing.Point(569, 304);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(32, 27);
            this.btn_show.TabIndex = 13;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.White;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.Location = new System.Drawing.Point(569, 304);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(32, 27);
            this.btn_hide.TabIndex = 12;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(360, 4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(320, 50);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 14;
            this.pic_logo.TabStop = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cikis.Location = new System.Drawing.Point(993, 55);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(30, 30);
            this.btn_cikis.TabIndex = 79;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.cmb_uzanti);
            this.Controls.Add(this.combo_kullanici);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_sifreonay);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_KullaniciTip);
            this.Controls.Add(this.lbl_SifreOnay);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kayit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Kayit_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_kullanici;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_sifreonay;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_KullaniciTip;
        private System.Windows.Forms.Label lbl_SifreOnay;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.ComboBox cmb_uzanti;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_cikis;
    }
}