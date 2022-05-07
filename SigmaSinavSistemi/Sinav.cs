using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class Sinav : Form
    {
        SoruHavuzu sorular = new SoruHavuzu();
        Sigma sigma = new Sigma();
        DateTime target;
        TimeSpan count = TimeSpan.FromMinutes(10);//Sınav süresi *dakika
        int NO = 1;
        public Sinav()
        {
            InitializeComponent();
            lbl_tarih.Text = DateTime.Now.ToString("dd MMMM dddd | yyyy");//Günün tarihini yazdırıyoruz
            sorular.SinavSorulari();
            SoruPaketi(NO);
            radio_Bos.Checked = true;
            target = DateTime.Now.Add(count);
            timer1.Start();
            
            //--------------------------------------------------------------------------------------
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
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
        public void SoruPaketi(int NO)
        {
            int id = sorular.sinav_soru[NO, 1];
            var soru = sorular.Listele(0).Find(x => x.Id == id);

            lbl_soruno.Text = string.Format("{0}/{1}", NO, sorular.soruSayi);
            lbl_konu.Text = soru.KonuAdi;
            string imagepath = Path.Combine(Application.StartupPath + "\\soru\\" + soru.GorselAd);
            pic_soru.ImageLocation = imagepath;
            label1.Text = soru.DogruCevap.ToString();
            label2.Text = id.ToString();
        }

        Point lastPoint;
        private void Sinav_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Sinav_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void btn_onceki_Click(object sender, EventArgs e)
        {
            if (NO != 1)
                NO--;
            else
                NO = sorular.soruSayi;
            SoruPaketi(NO);
            int isaret = sorular.sinav_soru[NO, 2];
            switch (isaret)
            {
                case 1:
                    radio_A.Checked = true;
                    break;
                case 2:
                    radio_B.Checked = true;
                    break;
                case 3:
                    radio_C.Checked = true;
                    break;
                case 4:
                    radio_D.Checked = true;
                    break;
                case 5:
                    radio_E.Checked = true;
                    break;
                case 0:
                    radio_Bos.Checked = true;
                    break;
            }
        }
        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            if (NO != sorular.soruSayi)
                NO++;
            else
                NO = 1;
            SoruPaketi(NO);
            int isaret = sorular.sinav_soru[NO, 2];
            switch (isaret)
            {
                case 1:
                    radio_A.Checked = true;
                    break;
                case 2:
                    radio_B.Checked = true;
                    break;
                case 3:
                    radio_C.Checked = true;
                    break;
                case 4:
                    radio_D.Checked = true;
                    break;
                case 5:
                    radio_E.Checked = true;
                    break;
                case 0:
                    radio_Bos.Checked = true;
                    break;
            }
        }
        private void btn_cizim_Click(object sender, EventArgs e)
        {
            DrawPad drw = new DrawPad();
            drw.Show();
        }
        private void btn_bitir_Click(object sender, EventArgs e)
        {
            DialogResult bitir = MessageBox.Show("Sınav sonlandırılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (bitir == DialogResult.Yes)
            {
                timer1.Stop();
                MessageBox.Show(sigma.SinaviBitir(sorular.sinav_soru));
                Anasayfa a = new Anasayfa();
                this.Close();
                a.Show();
            }
        }
        private void radio_Cevap(object sender, EventArgs e)
        {
            if (radio_A.Checked == true)
            {
                sorular.sinav_soru[NO, 2] = 1;
            }
            else if (radio_B.Checked == true)
            {
                sorular.sinav_soru[NO, 2] = 2;
            }
            else if (radio_C.Checked == true)
            {
                sorular.sinav_soru[NO, 2] = 3;
            }
            else if (radio_D.Checked == true)
            {
                sorular.sinav_soru[NO, 2] = 4;
            }
            else if (radio_E.Checked == true)
            {
                sorular.sinav_soru[NO, 2] = 5;
            }
            else if (radio_Bos.Checked == true)
            {
                sorular.sinav_soru[NO, 2] = 0;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult bitir = MessageBox.Show("Sınavın sonlandırılsın mı?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (bitir == DialogResult.Yes)
            {
                Anasayfa a = new Anasayfa();
                this.Close();
                a.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = target.Subtract(DateTime.Now);
            if (ts.TotalMilliseconds > 0)
            {
                lbl_sure.Text = ts.ToString(@"hh\:mm\:ss");
            }
            else
            {
                lbl_sure.Text = "00:00:00";
                timer1.Stop();
                sigma.SinaviBitir(sorular.sinav_soru);
                MessageBox.Show("Süreniz dolmuştur! \nSınav sonlandırılıyor...");
                this.Close();
                Anasayfa a = new Anasayfa();
                a.Show();
            }
        }
    }
}
