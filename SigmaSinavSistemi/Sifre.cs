using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SigmaSinavSistemi
{
    public partial class Sifre : Form
    {
        public Sifre()
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

        private void Sifre_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Sifre_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Random rnd = new Random();
        string onaykodu;


        private void btn_onayla_Click(object sender, EventArgs e)
        {
            DialogResult tamam = new DialogResult();

            if (txt_Onaykodu.Text == onaykodu)
            {
                tamam = MessageBox.Show("Güvenlik Kodu Doğru", "Mesaj", MessageBoxButtons.OK);
                if (tamam == DialogResult.OK)
                {
                    SifreGuncelleme guncelleme = new SifreGuncelleme();
                    guncelleme.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Güvenlik Kodu Hatalı");
            }
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            SifreGuncelle kontrol = new SifreGuncelle();
            string mail = txt_mail.Text + cmb_uzanti.Text;
            if (kontrol.MailKontrol(mail) != true)
            {
                MessageBox.Show("Bu Mail Sistemimize Kayıtlı Değildir.");
                txt_mail.Text = "";
            }
            else
            {

                MailMessage sms = new MailMessage();
                SmtpClient client = new SmtpClient();
                onaykodu = rnd.Next(999, 9999).ToString();
                client.Credentials = new NetworkCredential("sigmamatematik@outlook.com", "sigma1254");
                client.Port = 587;
                client.Host = "smtp.office365.com";
                client.EnableSsl = true;
                sms.To.Add(mail);
                sms.From = new MailAddress("sigmamatematik@outlook.com", "Sigma Matematik");
                sms.Subject = "Güvenlik Kodu";
                sms.Body = "Onay Kodunuz: " + onaykodu;
                client.Send(sms);
                MessageBox.Show("Güvenlik Kodu Gönderildi.");
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
