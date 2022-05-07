using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class KullaniciBilgiGuncelle : Form
    {
        public KullaniciBilgiGuncelle()
        {
            InitializeComponent();
            Kullanici kul = new Kullanici();

            data_bilgiGuncelleme.Visible = false;
            data_bilgiGuncelleme.DataSource = kul.KulListele(Giris.kulad);
            txt_kulad.Text = data_bilgiGuncelleme.Rows[0].Cells[1].Value.ToString();
            txt_ad.Text = data_bilgiGuncelleme.Rows[0].Cells[2].Value.ToString();
            txt_soyad.Text = data_bilgiGuncelleme.Rows[0].Cells[3].Value.ToString();
            txt_mail.Text = data_bilgiGuncelleme.Rows[0].Cells[4].Value.ToString();
        }

            
            
           
        private void linkLbl_Sifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreGuncelleme sifre = new SifreGuncelleme();
            sifre.Show();
            
            
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BilgiGuncelle_Click(object sender, EventArgs e)
        {
            Kullanici kul = new Kullanici();
            kul.KullaniciBilgiGuncelle(txt_kulad.Text,txt_ad.Text,txt_soyad.Text,txt_mail.Text);
            MessageBox.Show("Bilgiler Güncellenmiştir.");
            
        }
    }
}
