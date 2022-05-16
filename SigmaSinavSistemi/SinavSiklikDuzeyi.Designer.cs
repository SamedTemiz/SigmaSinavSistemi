
namespace SigmaSinavSistemi
{
    partial class SinavSiklikDuzeyi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavSiklikDuzeyi));
            this.radio_Az = new System.Windows.Forms.RadioButton();
            this.radio_Cok = new System.Windows.Forms.RadioButton();
            this.radio_Orta = new System.Windows.Forms.RadioButton();
            this.group_SoruDuzey = new System.Windows.Forms.GroupBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.group_SoruDuzey.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_Az
            // 
            this.radio_Az.AutoSize = true;
            this.radio_Az.Location = new System.Drawing.Point(6, 25);
            this.radio_Az.Name = "radio_Az";
            this.radio_Az.Size = new System.Drawing.Size(47, 24);
            this.radio_Az.TabIndex = 0;
            this.radio_Az.Text = "Az";
            this.radio_Az.UseVisualStyleBackColor = true;
            // 
            // radio_Cok
            // 
            this.radio_Cok.AutoSize = true;
            this.radio_Cok.Location = new System.Drawing.Point(6, 85);
            this.radio_Cok.Name = "radio_Cok";
            this.radio_Cok.Size = new System.Drawing.Size(55, 24);
            this.radio_Cok.TabIndex = 0;
            this.radio_Cok.Text = "Çok";
            this.radio_Cok.UseVisualStyleBackColor = true;
            // 
            // radio_Orta
            // 
            this.radio_Orta.AutoSize = true;
            this.radio_Orta.Location = new System.Drawing.Point(6, 55);
            this.radio_Orta.Name = "radio_Orta";
            this.radio_Orta.Size = new System.Drawing.Size(59, 24);
            this.radio_Orta.TabIndex = 0;
            this.radio_Orta.Text = "Orta";
            this.radio_Orta.UseVisualStyleBackColor = true;
            // 
            // group_SoruDuzey
            // 
            this.group_SoruDuzey.BackColor = System.Drawing.Color.Transparent;
            this.group_SoruDuzey.Controls.Add(this.radio_Orta);
            this.group_SoruDuzey.Controls.Add(this.radio_Cok);
            this.group_SoruDuzey.Controls.Add(this.radio_Az);
            this.group_SoruDuzey.Location = new System.Drawing.Point(32, 29);
            this.group_SoruDuzey.Name = "group_SoruDuzey";
            this.group_SoruDuzey.Size = new System.Drawing.Size(175, 125);
            this.group_SoruDuzey.TabIndex = 1;
            this.group_SoruDuzey.TabStop = false;
            this.group_SoruDuzey.Text = "Soru Sıklık Düzeyi";
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Location = new System.Drawing.Point(69, 171);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(94, 29);
            this.btn_Gonder.TabIndex = 2;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cikis.Location = new System.Drawing.Point(203, 6);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(30, 30);
            this.btn_cikis.TabIndex = 80;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // SinavSiklikDuzeyi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(240, 230);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.group_SoruDuzey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinavSiklikDuzeyi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinavSiklikDuzeyi";
            this.group_SoruDuzey.ResumeLayout(false);
            this.group_SoruDuzey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_Az;
        private System.Windows.Forms.RadioButton radio_Cok;
        private System.Windows.Forms.RadioButton radio_Orta;
        private System.Windows.Forms.GroupBox group_SoruDuzey;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.Button btn_cikis;
    }
}