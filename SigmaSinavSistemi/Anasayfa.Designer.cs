
namespace SigmaSinavSistemi
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavlarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavaGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavSıklıkDüzeyiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_SinavHakkinda = new System.Windows.Forms.TextBox();
            this.lbl_SinavHakkinda = new System.Windows.Forms.Label();
            this.txt_SigHakkinda = new System.Windows.Forms.TextBox();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Hakkinda = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_Saat = new System.Windows.Forms.Label();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.t_saat = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıBilgileriToolStripMenuItem,
            this.sınavlarımToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1050, 30);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıBilgileriToolStripMenuItem.Image")));
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Anasayfa";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // sınavlarımToolStripMenuItem
            // 
            this.sınavlarımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sınavaGirToolStripMenuItem,
            this.istatistikToolStripMenuItem});
            this.sınavlarımToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sınavlarımToolStripMenuItem.Image")));
            this.sınavlarımToolStripMenuItem.Name = "sınavlarımToolStripMenuItem";
            this.sınavlarımToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.sınavlarımToolStripMenuItem.Text = "Sınavlarım";
            // 
            // sınavaGirToolStripMenuItem
            // 
            this.sınavaGirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sınavaGirToolStripMenuItem.Image")));
            this.sınavaGirToolStripMenuItem.Name = "sınavaGirToolStripMenuItem";
            this.sınavaGirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sınavaGirToolStripMenuItem.Text = "Sınava Gir";
            this.sınavaGirToolStripMenuItem.Click += new System.EventHandler(this.sınavaGirToolStripMenuItem_Click);
            // 
            // istatistikToolStripMenuItem
            // 
            this.istatistikToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("istatistikToolStripMenuItem.Image")));
            this.istatistikToolStripMenuItem.Name = "istatistikToolStripMenuItem";
            this.istatistikToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.istatistikToolStripMenuItem.Text = "İstatistik";
            this.istatistikToolStripMenuItem.Click += new System.EventHandler(this.istatistikToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıBilgileriToolStripMenuItem1});
            this.profilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profilToolStripMenuItem.Image")));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // kullanıcıBilgileriToolStripMenuItem1
            // 
            this.kullanıcıBilgileriToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıBilgileriToolStripMenuItem1.Image")));
            this.kullanıcıBilgileriToolStripMenuItem1.Name = "kullanıcıBilgileriToolStripMenuItem1";
            this.kullanıcıBilgileriToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.kullanıcıBilgileriToolStripMenuItem1.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem1.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem1_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıAyarlarıToolStripMenuItem,
            this.sınavSıklıkDüzeyiToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // kullanıcıAyarlarıToolStripMenuItem
            // 
            this.kullanıcıAyarlarıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıAyarlarıToolStripMenuItem.Image")));
            this.kullanıcıAyarlarıToolStripMenuItem.Name = "kullanıcıAyarlarıToolStripMenuItem";
            this.kullanıcıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kullanıcıAyarlarıToolStripMenuItem.Text = "Kullanıcı Ayarları";
            this.kullanıcıAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıAyarlarıToolStripMenuItem_Click);
            // 
            // sınavSıklıkDüzeyiToolStripMenuItem
            // 
            this.sınavSıklıkDüzeyiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sınavSıklıkDüzeyiToolStripMenuItem.Image")));
            this.sınavSıklıkDüzeyiToolStripMenuItem.Name = "sınavSıklıkDüzeyiToolStripMenuItem";
            this.sınavSıklıkDüzeyiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sınavSıklıkDüzeyiToolStripMenuItem.Text = "Sınav Sıklık Düzeyi";
            this.sınavSıklıkDüzeyiToolStripMenuItem.Click += new System.EventHandler(this.sınavSıklıkDüzeyiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txt_SinavHakkinda);
            this.panel1.Controls.Add(this.lbl_SinavHakkinda);
            this.panel1.Controls.Add(this.txt_SigHakkinda);
            this.panel1.Controls.Add(this.Pic_Logo);
            this.panel1.Controls.Add(this.lbl_Hakkinda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 569);
            this.panel1.TabIndex = 36;
            // 
            // txt_SinavHakkinda
            // 
            this.txt_SinavHakkinda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SinavHakkinda.Location = new System.Drawing.Point(59, 255);
            this.txt_SinavHakkinda.Multiline = true;
            this.txt_SinavHakkinda.Name = "txt_SinavHakkinda";
            this.txt_SinavHakkinda.ReadOnly = true;
            this.txt_SinavHakkinda.Size = new System.Drawing.Size(796, 137);
            this.txt_SinavHakkinda.TabIndex = 4;
            // 
            // lbl_SinavHakkinda
            // 
            this.lbl_SinavHakkinda.AutoSize = true;
            this.lbl_SinavHakkinda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SinavHakkinda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SinavHakkinda.Location = new System.Drawing.Point(59, 232);
            this.lbl_SinavHakkinda.Name = "lbl_SinavHakkinda";
            this.lbl_SinavHakkinda.Size = new System.Drawing.Size(173, 20);
            this.lbl_SinavHakkinda.TabIndex = 3;
            this.lbl_SinavHakkinda.Text = "Sınav Hakkında Bilgiler:";
            // 
            // txt_SigHakkinda
            // 
            this.txt_SigHakkinda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SigHakkinda.Location = new System.Drawing.Point(301, 93);
            this.txt_SigHakkinda.Multiline = true;
            this.txt_SigHakkinda.Name = "txt_SigHakkinda";
            this.txt_SigHakkinda.ReadOnly = true;
            this.txt_SigHakkinda.Size = new System.Drawing.Size(555, 127);
            this.txt_SigHakkinda.TabIndex = 2;
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.Image")));
            this.Pic_Logo.Location = new System.Drawing.Point(65, 69);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(230, 149);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Logo.TabIndex = 1;
            this.Pic_Logo.TabStop = false;
            // 
            // lbl_Hakkinda
            // 
            this.lbl_Hakkinda.AutoSize = true;
            this.lbl_Hakkinda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hakkinda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hakkinda.Location = new System.Drawing.Point(301, 69);
            this.lbl_Hakkinda.Name = "lbl_Hakkinda";
            this.lbl_Hakkinda.Size = new System.Drawing.Size(194, 20);
            this.lbl_Hakkinda.TabIndex = 0;
            this.lbl_Hakkinda.Text = "Sig{MA}tematik Hakkında:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1166, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(34, 28);
            this.btn_close.TabIndex = 33;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Saat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Saat.Location = new System.Drawing.Point(979, 5);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(39, 20);
            this.lbl_Saat.TabIndex = 5;
            this.lbl_Saat.Text = "Saat";
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tarih.Location = new System.Drawing.Point(729, 5);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(90, 20);
            this.lbl_Tarih.TabIndex = 6;
            this.lbl_Tarih.Text = "Tarih Bilgisi";
            // 
            // t_saat
            // 
            this.t_saat.Enabled = true;
            this.t_saat.Interval = 1000;
            this.t_saat.Tick += new System.EventHandler(this.t_saat_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(690, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(939, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_Saat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavlarımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavaGirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_SinavHakkinda;
        private System.Windows.Forms.Label lbl_SinavHakkinda;
        private System.Windows.Forms.TextBox txt_SigHakkinda;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Label lbl_Hakkinda;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label lbl_Saat;
        private System.Windows.Forms.Timer t_saat;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistikToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavSıklıkDüzeyiToolStripMenuItem;
    }
}