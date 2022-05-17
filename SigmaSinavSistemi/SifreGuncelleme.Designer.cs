
namespace SigmaSinavSistemi
{
    partial class SifreGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGuncelleme));
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_sifreguncelle = new System.Windows.Forms.Button();
            this.lbl_sifreonay = new System.Windows.Forms.Label();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.txt_yenisifreonay = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.lbl_kulad = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sifre.Location = new System.Drawing.Point(41, 74);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(78, 20);
            this.lbl_sifre.TabIndex = 7;
            this.lbl_sifre.Text = "Yeni Şifre:";
            // 
            // btn_sifreguncelle
            // 
            this.btn_sifreguncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sifreguncelle.Location = new System.Drawing.Point(142, 137);
            this.btn_sifreguncelle.Name = "btn_sifreguncelle";
            this.btn_sifreguncelle.Size = new System.Drawing.Size(94, 29);
            this.btn_sifreguncelle.TabIndex = 4;
            this.btn_sifreguncelle.Text = "Güncelle";
            this.btn_sifreguncelle.UseVisualStyleBackColor = true;
            this.btn_sifreguncelle.Click += new System.EventHandler(this.btn_sifreguncelle_Click);
            // 
            // lbl_sifreonay
            // 
            this.lbl_sifreonay.AutoSize = true;
            this.lbl_sifreonay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifreonay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sifreonay.Location = new System.Drawing.Point(34, 108);
            this.lbl_sifreonay.Name = "lbl_sifreonay";
            this.lbl_sifreonay.Size = new System.Drawing.Size(85, 20);
            this.lbl_sifreonay.TabIndex = 8;
            this.lbl_sifreonay.Text = "Şifre Onay:";
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(129, 72);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.PasswordChar = '*';
            this.txt_yenisifre.PlaceholderText = "Yeni Şifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(159, 27);
            this.txt_yenisifre.TabIndex = 2;
            // 
            // txt_yenisifreonay
            // 
            this.txt_yenisifreonay.Location = new System.Drawing.Point(129, 104);
            this.txt_yenisifreonay.Name = "txt_yenisifreonay";
            this.txt_yenisifreonay.PasswordChar = '*';
            this.txt_yenisifreonay.PlaceholderText = "Şifre Onay";
            this.txt_yenisifreonay.Size = new System.Drawing.Size(159, 27);
            this.txt_yenisifreonay.TabIndex = 3;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Location = new System.Drawing.Point(129, 38);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.PlaceholderText = "Kullanıcı Adı";
            this.txt_kulad.Size = new System.Drawing.Size(159, 27);
            this.txt_kulad.TabIndex = 1;
            // 
            // lbl_kulad
            // 
            this.lbl_kulad.AutoSize = true;
            this.lbl_kulad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kulad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kulad.Location = new System.Drawing.Point(19, 42);
            this.lbl_kulad.Name = "lbl_kulad";
            this.lbl_kulad.Size = new System.Drawing.Size(100, 20);
            this.lbl_kulad.TabIndex = 6;
            this.lbl_kulad.Text = "Kullanıcı Adı:";
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.White;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.Location = new System.Drawing.Point(256, 72);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(32, 27);
            this.btn_show.TabIndex = 14;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.White;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.Location = new System.Drawing.Point(256, 72);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(32, 27);
            this.btn_hide.TabIndex = 15;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cikis.Location = new System.Drawing.Point(290, -1);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(30, 30);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // SifreGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(320, 189);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.lbl_kulad);
            this.Controls.Add(this.txt_yenisifreonay);
            this.Controls.Add(this.btn_sifreguncelle);
            this.Controls.Add(this.lbl_sifreonay);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_yenisifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDogrula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_sifreguncelle;
        private System.Windows.Forms.Label lbl_sifreonay;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.TextBox txt_yenisifreonay;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.Label lbl_kulad;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_cikis;
    }
}