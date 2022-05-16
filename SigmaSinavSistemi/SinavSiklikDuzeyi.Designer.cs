
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
            this.radio_Az = new System.Windows.Forms.RadioButton();
            this.radio_Cok = new System.Windows.Forms.RadioButton();
            this.radio_Orta = new System.Windows.Forms.RadioButton();
            this.group_SoruDuzey = new System.Windows.Forms.GroupBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
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
            this.group_SoruDuzey.Controls.Add(this.radio_Orta);
            this.group_SoruDuzey.Controls.Add(this.radio_Cok);
            this.group_SoruDuzey.Controls.Add(this.radio_Az);
            this.group_SoruDuzey.Location = new System.Drawing.Point(22, 22);
            this.group_SoruDuzey.Name = "group_SoruDuzey";
            this.group_SoruDuzey.Size = new System.Drawing.Size(175, 125);
            this.group_SoruDuzey.TabIndex = 1;
            this.group_SoruDuzey.TabStop = false;
            this.group_SoruDuzey.Text = "Soru Sıklık Düzeyi";
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Location = new System.Drawing.Point(59, 164);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(94, 29);
            this.btn_Gonder.TabIndex = 2;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // SinavSiklikDuzeyi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 228);
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
    }
}