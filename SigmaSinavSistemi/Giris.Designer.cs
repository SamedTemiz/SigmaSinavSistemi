
namespace SigmaSinavSistemi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.link_sifre = new System.Windows.Forms.LinkLabel();
            this.link_kayit = new System.Windows.Forms.LinkLabel();
            this.lbl_kulad = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kulad
            // 
            this.txt_kulad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_kulad.Location = new System.Drawing.Point(375, 176);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.PlaceholderText = "KULLANICI ADI";
            this.txt_kulad.Size = new System.Drawing.Size(175, 29);
            this.txt_kulad.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sifre.Location = new System.Drawing.Point(375, 208);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.PlaceholderText = "ŞİFRE";
            this.txt_sifre.Size = new System.Drawing.Size(175, 29);
            this.txt_sifre.TabIndex = 12;
            // 
            // link_sifre
            // 
            this.link_sifre.AutoSize = true;
            this.link_sifre.BackColor = System.Drawing.Color.Transparent;
            this.link_sifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_sifre.LinkColor = System.Drawing.Color.Black;
            this.link_sifre.Location = new System.Drawing.Point(301, 240);
            this.link_sifre.Name = "link_sifre";
            this.link_sifre.Size = new System.Drawing.Size(124, 21);
            this.link_sifre.TabIndex = 13;
            this.link_sifre.TabStop = true;
            this.link_sifre.Text = "Şifremi unuttum";
            this.link_sifre.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // link_kayit
            // 
            this.link_kayit.AutoSize = true;
            this.link_kayit.BackColor = System.Drawing.Color.Transparent;
            this.link_kayit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_kayit.LinkColor = System.Drawing.Color.Black;
            this.link_kayit.Location = new System.Drawing.Point(522, 240);
            this.link_kayit.Name = "link_kayit";
            this.link_kayit.Size = new System.Drawing.Size(61, 21);
            this.link_kayit.TabIndex = 25;
            this.link_kayit.TabStop = true;
            this.link_kayit.Text = "Kayıt ol";
            this.link_kayit.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lbl_kulad
            // 
            this.lbl_kulad.AutoSize = true;
            this.lbl_kulad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kulad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kulad.Location = new System.Drawing.Point(254, 179);
            this.lbl_kulad.Name = "lbl_kulad";
            this.lbl_kulad.Size = new System.Drawing.Size(115, 21);
            this.lbl_kulad.TabIndex = 27;
            this.lbl_kulad.Text = "Kullanıcı Adı :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sifre.Location = new System.Drawing.Point(316, 211);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(53, 21);
            this.lbl_sifre.TabIndex = 28;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.White;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.Location = new System.Drawing.Point(522, 208);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(28, 26);
            this.btn_hide.TabIndex = 29;
            this.btn_hide.UseVisualStyleBackColor = false;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.White;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.Location = new System.Drawing.Point(522, 208);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(28, 26);
            this.btn_show.TabIndex = 30;
            this.btn_show.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(216, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "öğrenci: kulad:mert şif:2 - admin : kulad: samed şif:1 - sınav sorumlusu : kulad:" +
    "yusuf şif:1";
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(316, 0);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(280, 38);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 32;
            this.pic_logo.TabStop = false;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_giris.Location = new System.Drawing.Point(375, 275);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(175, 29);
            this.btn_giris.TabIndex = 33;
            this.btn_giris.Text = "GİRİŞ YAP";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kulad);
            this.Controls.Add(this.link_kayit);
            this.Controls.Add(this.link_sifre);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.txt_sifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.LinkLabel link_sifre;
        private System.Windows.Forms.LinkLabel link_kayit;
        private System.Windows.Forms.Label lbl_kulad;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_giris;
    }
}