using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class Anasayfa : Form
    {
        Sigma sigma = new Sigma();
        public Anasayfa()
        {
            InitializeComponent();
            sigma.TarihGuncelle();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            txt_SigHakkinda.Text = "Uygulamamamız, 01.05.2022 Tarihinde Sig{MA}tematik adı altında Mert Fazlı Saylak, Abdussamed Temiz ve Muhammed Yusuf Bozkurt tarafından kodlanmıştır.";

            txt_SinavHakkinda.Text = "Sınavlarımızda Kolay,Orta ve Zor olmak üzere 3 tane seviye vardır. Bu zorluk seviyelerine göre soru süresi artmakta veya azalmaktadır. Soruları doğru bilme sıklığına göre sorular karşınıza çıkacaktır. Eğer bu sıklığı arttırmak isterseniz ; Yukarıdaki sekmelerden 'Sınavlarım-> Sınav Özellikleri-> Soru Sıklığı' adımlarını izleyerek sıklık düzeyini değiştirebilirsiniz.";

            lbl_Tarih.Text= DateTime.Now.ToString("dd MMMM dddd | yyyy");
           
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        Point lastPoint;
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult start = MessageBox.Show("Test başlatılsın mı?", "Başlat", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (start == DialogResult.OK)
            { 
                Sinav s = new Sinav();
                s.Show();
                this.Close();
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult start = MessageBox.Show("Oturum kapatılsın mı?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (start == DialogResult.Yes)
            {
                Giris g = new Giris();
                g.Show();
                this.Close();
            }
        }
        private void sınavaGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult start = MessageBox.Show("Sınav başlatılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (start == DialogResult.Yes)
            {
                Sinav sv = new Sinav();
                sv.Show();
                this.Close();
            }
        }
        private void t_saat_Tick(object sender, EventArgs e)
        {
            lbl_Saat.Text = DateTime.Now.ToShortTimeString();
        }
        private void kullanıcıBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri kul = new KullaniciBilgileri();
            kul.Show();  
        }
        private void kullanıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciBilgiGuncelle bilgi = new KullaniciBilgiGuncelle();
            bilgi.Show();
        }
        private void istatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istatistik i = new Istatistik();
            i.Show();
            this.Close();
        }
        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Close();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult shut = MessageBox.Show("Uygulama kapatılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (shut == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void sınavÖzellikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
