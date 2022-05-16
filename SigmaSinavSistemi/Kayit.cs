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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
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
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Kullanici ekle = new Kullanici();
            string mail = txt_mail.Text + cmb_uzanti.Text;
            ekle.KullaniciAd = txt_kulad.Text;
            ekle.Ad = txt_ad.Text;
            ekle.Soyad = txt_soyad.Text;
            ekle.Mail = mail;
            ekle.Sifre = txt_sifre.Text;
            ekle.KullaniciTipID = combo_kullanici.SelectedIndex;

            if (txt_sifre.Text != txt_sifreonay.Text)
            {
                MessageBox.Show("Şifreler Aynı Değil.");
                txt_sifre.Text = "";
                txt_sifreonay.Text = "";
            }
            else
            {
                if (ekle.MailKontrol(mail) == true)
                {
                    MessageBox.Show("Bu Mail Zaten Sisteme Kayıtlı!");
                }
                else
                {
                    if (ekle.ekleKullanici(ekle) != true)
                    {
                        MessageBox.Show("Bu Kullanıcı Adına Sahip Bir Hesap Bulunmaktadır!");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarılı.");
                        Giris g = new Giris();
                        g.Show();
                        this.Close();
                    }
                }
            }
        }
        private void Kayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Kayit_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_sifre.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_sifre.PasswordChar = '\0';
                txt_sifreonay.PasswordChar = '\0';
            }
        }
        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_sifre.PasswordChar == '\0')
            {
                btn_show.BringToFront();
                txt_sifre.PasswordChar = '*';
                txt_sifreonay.PasswordChar = '*';
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
