
namespace SigmaSinavSistemi
{
    partial class Sinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinav));
            this.btn_bitir = new System.Windows.Forms.Button();
            this.btn_cizim = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.pic_soru = new System.Windows.Forms.PictureBox();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.lbl_konu = new System.Windows.Forms.Label();
            this.lbl_soruno = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_sure = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.radio_A = new System.Windows.Forms.RadioButton();
            this.radio_B = new System.Windows.Forms.RadioButton();
            this.radio_C = new System.Windows.Forms.RadioButton();
            this.radio_D = new System.Windows.Forms.RadioButton();
            this.radio_E = new System.Windows.Forms.RadioButton();
            this.radio_Bos = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_soru)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bitir
            // 
            this.btn_bitir.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bitir.Location = new System.Drawing.Point(1008, 709);
            this.btn_bitir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(160, 53);
            this.btn_bitir.TabIndex = 0;
            this.btn_bitir.Text = "SINAVI BİTİR";
            this.btn_bitir.UseVisualStyleBackColor = true;
            this.btn_bitir.Click += new System.EventHandler(this.btn_bitir_Click);
            // 
            // btn_cizim
            // 
            this.btn_cizim.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cizim.Location = new System.Drawing.Point(32, 709);
            this.btn_cizim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cizim.Name = "btn_cizim";
            this.btn_cizim.Size = new System.Drawing.Size(160, 53);
            this.btn_cizim.TabIndex = 2;
            this.btn_cizim.Text = "ÇİZİM YAP";
            this.btn_cizim.UseVisualStyleBackColor = true;
            this.btn_cizim.Click += new System.EventHandler(this.btn_cizim_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_onceki.Location = new System.Drawing.Point(173, 588);
            this.btn_onceki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(114, 43);
            this.btn_onceki.TabIndex = 3;
            this.btn_onceki.Text = "ÖNCEKİ";
            this.btn_onceki.UseVisualStyleBackColor = true;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // pic_soru
            // 
            this.pic_soru.Location = new System.Drawing.Point(173, 113);
            this.pic_soru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_soru.Name = "pic_soru";
            this.pic_soru.Size = new System.Drawing.Size(857, 467);
            this.pic_soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_soru.TabIndex = 4;
            this.pic_soru.TabStop = false;
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sonraki.Location = new System.Drawing.Point(915, 588);
            this.btn_sonraki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(114, 44);
            this.btn_sonraki.TabIndex = 5;
            this.btn_sonraki.Text = "SONRAKİ";
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // lbl_konu
            // 
            this.lbl_konu.AutoSize = true;
            this.lbl_konu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_konu.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_konu.Location = new System.Drawing.Point(173, 68);
            this.lbl_konu.Name = "lbl_konu";
            this.lbl_konu.Size = new System.Drawing.Size(100, 38);
            this.lbl_konu.TabIndex = 6;
            this.lbl_konu.Text = "KONULAR";
            // 
            // lbl_soruno
            // 
            this.lbl_soruno.AutoSize = true;
            this.lbl_soruno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soruno.Font = new System.Drawing.Font("Bebas Neue", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soruno.Location = new System.Drawing.Point(963, 68);
            this.lbl_soruno.Name = "lbl_soruno";
            this.lbl_soruno.Size = new System.Drawing.Size(76, 38);
            this.lbl_soruno.TabIndex = 7;
            this.lbl_soruno.Text = "10/10";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sure.Font = new System.Drawing.Font("Bebas Neue", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sure.Location = new System.Drawing.Point(523, 693);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(166, 66);
            this.lbl_sure.TabIndex = 8;
            this.lbl_sure.Text = "00:00:00";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tarih.Font = new System.Drawing.Font("Bebas Neue", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tarih.ForeColor = System.Drawing.Color.White;
            this.lbl_tarih.Location = new System.Drawing.Point(29, 3);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(229, 29);
            this.lbl_tarih.TabIndex = 9;
            this.lbl_tarih.Text = "30 Ağustos Cumartesi | 2022";
            // 
            // radio_A
            // 
            this.radio_A.AutoSize = true;
            this.radio_A.BackColor = System.Drawing.Color.Transparent;
            this.radio_A.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_A.Location = new System.Drawing.Point(333, 589);
            this.radio_A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_A.Name = "radio_A";
            this.radio_A.Size = new System.Drawing.Size(54, 39);
            this.radio_A.TabIndex = 10;
            this.radio_A.TabStop = true;
            this.radio_A.Text = "A";
            this.radio_A.UseVisualStyleBackColor = false;
            this.radio_A.CheckedChanged += new System.EventHandler(this.radio_Cevap);
            // 
            // radio_B
            // 
            this.radio_B.AutoSize = true;
            this.radio_B.BackColor = System.Drawing.Color.Transparent;
            this.radio_B.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_B.Location = new System.Drawing.Point(429, 589);
            this.radio_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_B.Name = "radio_B";
            this.radio_B.Size = new System.Drawing.Size(52, 39);
            this.radio_B.TabIndex = 11;
            this.radio_B.TabStop = true;
            this.radio_B.Text = "B";
            this.radio_B.UseVisualStyleBackColor = false;
            this.radio_B.CheckedChanged += new System.EventHandler(this.radio_Cevap);
            // 
            // radio_C
            // 
            this.radio_C.AutoSize = true;
            this.radio_C.BackColor = System.Drawing.Color.Transparent;
            this.radio_C.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_C.Location = new System.Drawing.Point(523, 589);
            this.radio_C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_C.Name = "radio_C";
            this.radio_C.Size = new System.Drawing.Size(52, 39);
            this.radio_C.TabIndex = 12;
            this.radio_C.TabStop = true;
            this.radio_C.Text = "C";
            this.radio_C.UseVisualStyleBackColor = false;
            this.radio_C.CheckedChanged += new System.EventHandler(this.radio_Cevap);
            // 
            // radio_D
            // 
            this.radio_D.AutoSize = true;
            this.radio_D.BackColor = System.Drawing.Color.Transparent;
            this.radio_D.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_D.Location = new System.Drawing.Point(617, 589);
            this.radio_D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_D.Name = "radio_D";
            this.radio_D.Size = new System.Drawing.Size(54, 39);
            this.radio_D.TabIndex = 13;
            this.radio_D.TabStop = true;
            this.radio_D.Text = "D";
            this.radio_D.UseVisualStyleBackColor = false;
            this.radio_D.CheckedChanged += new System.EventHandler(this.radio_Cevap);
            // 
            // radio_E
            // 
            this.radio_E.AutoSize = true;
            this.radio_E.BackColor = System.Drawing.Color.Transparent;
            this.radio_E.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_E.Location = new System.Drawing.Point(714, 589);
            this.radio_E.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_E.Name = "radio_E";
            this.radio_E.Size = new System.Drawing.Size(49, 39);
            this.radio_E.TabIndex = 14;
            this.radio_E.TabStop = true;
            this.radio_E.Text = "E";
            this.radio_E.UseVisualStyleBackColor = false;
            this.radio_E.CheckedChanged += new System.EventHandler(this.radio_Cevap);
            // 
            // radio_Bos
            // 
            this.radio_Bos.AutoSize = true;
            this.radio_Bos.BackColor = System.Drawing.Color.Transparent;
            this.radio_Bos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radio_Bos.Location = new System.Drawing.Point(807, 589);
            this.radio_Bos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_Bos.Name = "radio_Bos";
            this.radio_Bos.Size = new System.Drawing.Size(85, 39);
            this.radio_Bos.TabIndex = 15;
            this.radio_Bos.TabStop = true;
            this.radio_Bos.Text = "BOŞ";
            this.radio_Bos.UseVisualStyleBackColor = false;
            this.radio_Bos.CheckedChanged += new System.EventHandler(this.radio_Cevap);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(1169, 3);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 33);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Sinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.radio_Bos);
            this.Controls.Add(this.radio_E);
            this.Controls.Add(this.radio_D);
            this.Controls.Add(this.radio_C);
            this.Controls.Add(this.radio_B);
            this.Controls.Add(this.radio_A);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.lbl_soruno);
            this.Controls.Add(this.lbl_konu);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.pic_soru);
            this.Controls.Add(this.btn_onceki);
            this.Controls.Add(this.btn_cizim);
            this.Controls.Add(this.btn_bitir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinav";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sinav_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sinav_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_soru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bitir;
        private System.Windows.Forms.Button btn_cizim;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.PictureBox pic_soru;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Label lbl_konu;
        private System.Windows.Forms.Label lbl_soruno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.RadioButton radio_A;
        private System.Windows.Forms.RadioButton radio_B;
        private System.Windows.Forms.RadioButton radio_C;
        private System.Windows.Forms.RadioButton radio_D;
        private System.Windows.Forms.RadioButton radio_E;
        private System.Windows.Forms.RadioButton radio_Bos;
        private System.Windows.Forms.Button btn_close;
    }
}