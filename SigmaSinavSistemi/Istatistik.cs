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
    public partial class Istatistik : Form
    {
        SoruHavuzu sorular = new SoruHavuzu();
        Sigma sigma = new Sigma();

        public Istatistik()
        {
            InitializeComponent();
            lbl_tarih.Text = DateTime.Now.ToString("dd MMMM dddd | yyyy");//Günün tarihini yazdırıyoruz
            Bilgiler();
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
        public void Bilgiler()
        {
            lbl_toplamSoru.Text = Sonuclar.toplamSoru.ToString();
            lbl_cozulenSoru.Text = (Sonuclar.toplamSoru - Sonuclar.bos).ToString();
            lbl_sinavSure.Text = string.Format("{0} dakika", Sonuclar.sure);
            lbl_harcananSure.Text = Sonuclar.harcanan_sure;
            lbl_sigmaSoru.Text = sigma.Dereceliler().Length.ToString();

            lbl_dogru.Text = Sonuclar.dogru.ToString();
            lbl_yanlis.Text = Sonuclar.yanlis.ToString();
            lbl_bos.Text = Sonuclar.bos.ToString();

            int cozulen = int.Parse(lbl_cozulenSoru.Text);
            int dogru = int.Parse(lbl_dogru.Text);
            lbl_basari.Text = string.Format("%{0}", BasariOran(cozulen, dogru));
        }
        public double BasariOran(int cozulen, int dogru)
        { 
            double basari;
            if(dogru !=  0)
                basari = (dogru * 100) / cozulen;
            basari = 0.00;
            return basari;
        }

        Point lastPoint;
        private void Istatistik_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Istatistik_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void btn_yazdir_Click(object sender, EventArgs e)
        {

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Close();
        }
    }
}
