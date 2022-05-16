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
    public partial class Giris : Form
    {
        public static int kulid;
        public static string kulad;
        Sigma sigma = new Sigma();
        public Giris()
        {
            InitializeComponent();
            sigma.TarihGuncelle();
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
        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            var oturum = k.girisKullanici(txt_kulad.Text, txt_sifre.Text);
            if (oturum != null)
            {
                kulid = oturum.Id;
                kulad = oturum.KullaniciAd;
                switch (oturum.KullaniciTipID)
                {

                    case 1:
                        Anasayfa ana = new Anasayfa();

                        ana.Show();
                        this.Hide();
                        break;
                    case 2:
                        Admin a = new Admin();
                        a.Show();
                        this.Hide();
                        break;
                    case 3:
                        Sorumlu s = new Sorumlu();
                        s.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Giriş bilgileriniz hatalı!");
                txt_kulad.Text = "";
                txt_sifre.Text = "";
            }
        }
        private void link_sifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifre form2 = new Sifre();
            form2.Show();
            this.Hide();

           
        }
        private void link_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit form3 = new Kayit();
            form3.Show();
            this.Hide();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_sifre.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_sifre.PasswordChar = '\0';
            }
        }
        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_sifre.PasswordChar == '\0')
            {
                btn_show.BringToFront();
                txt_sifre.PasswordChar = '*';
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
