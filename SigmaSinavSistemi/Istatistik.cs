using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace SigmaSinavSistemi
{
    public partial class Istatistik : Form
    {
        SoruHavuzu sorular = new SoruHavuzu();
        Sigma sigma = new Sigma();
        Sonuclar sonuc = new Sonuclar();
        KonuIstatistik konu = new KonuIstatistik();
        public Istatistik()
        {
            InitializeComponent();
            lbl_tarih.Text = DateTime.Now.ToString("dd MMMM dddd | yyyy");//Günün tarihini yazdırıyoruz
            bar_ilerleme.ForeColor = Color.Red;
            data_sonuclistesi.DataSource = sonuc.SonucListele();
            int satir = data_sonuclistesi.Rows.Count;
            combo_konular.SelectedIndex = 0;
            //Bilgiler();
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
        private void btn_close_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Close();
        }
        public void Yazdir()
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.metroTabControl1.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);

            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void SinavSecimi(object sender, EventArgs e)
        {
            int toplam, cozulen, dogru, yanlis, bos, sigma;
            toplam = int.Parse(data_sonuclistesi.CurrentRow.Cells[2].Value.ToString());
            bos = int.Parse(data_sonuclistesi.CurrentRow.Cells[4].Value.ToString());
            cozulen = toplam - bos;
            sigma = toplam - Sorumlu.SoruAdet;

            dogru = int.Parse(data_sonuclistesi.CurrentRow.Cells[3].Value.ToString());
            yanlis = toplam - (dogru + bos);

            DateTime tarih = Convert.ToDateTime(data_sonuclistesi.CurrentRow.Cells[8].Value);
            lbl_sinavno.Text = string.Format("SINAV NO : {0}", data_sonuclistesi.CurrentRow.Cells[0].Value.ToString());

            lbl_toplamSoru.Text = toplam.ToString();
            lbl_cozulenSoru.Text = cozulen.ToString();
            lbl_sinavSure.Text = data_sonuclistesi.CurrentRow.Cells[5].Value.ToString();
            lbl_harcananSure.Text = data_sonuclistesi.CurrentRow.Cells[6].Value.ToString();
            lbl_sigmaSoru.Text = sigma.ToString();

            lbl_dogru.Text = dogru.ToString();
            lbl_yanlis.Text = yanlis.ToString();
            lbl_bos.Text = bos.ToString();

            lbl_basari.Text = string.Format("%{0}", data_sonuclistesi.CurrentRow.Cells[7].Value.ToString());
            lbl_sinavTarih.Text = tarih.ToString("dd MMMM dddd | yyyy");
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            Yazdir();
        }
        private void btn_yazdir2_Click(object sender, EventArgs e)
        {
            Yazdir();
        }
        public void KonuyaGore(int konuID)
        {
            var veri = konu.Istatistik().Find(x => x.Konu_ID == konuID);

            int soruSayisi, dereceli, dogru, yanlis, k_puan, a_puan;
            double basari, ilerleme;
            
            soruSayisi = int.Parse(veri.SoruSayisi.ToString());
            dereceli = int.Parse(veri.Dereceli.ToString());
            dogru = int.Parse(veri.Dogru.ToString());
            yanlis = int.Parse(veri.Yanlis.ToString());
            k_puan = int.Parse(veri.KonuPuan.ToString());
            a_puan = int.Parse(veri.AlinanPuan.ToString());

            lbl_soruSayisi.Text = soruSayisi.ToString();
            lbl_dereceli.Text = dereceli.ToString();
            lbl_konuDogru.Text = dogru.ToString();
            lbl_konuYanlis.Text = yanlis.ToString();
            lbl_konuPuan.Text = k_puan.ToString();
            lbl_alinanPuan.Text = a_puan.ToString();

            basari = (a_puan * 100) / k_puan;
            ilerleme = (dogru * a_puan * 100) / (soruSayisi * k_puan); 
            lbl_basariOran.Text = string.Format("%{0}", basari);
            spin_basari.Value = (int)basari;
            lbl_ilerleme.Text = string.Format("%{0}", ilerleme);
            bar_ilerleme.Value = (int)ilerleme;
        }
        private void combo_konular_SelectedIndexChanged(object sender, EventArgs e)
        {
            KonuyaGore(combo_konular.SelectedIndex + 1);
        }
    }
}
