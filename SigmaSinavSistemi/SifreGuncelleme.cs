using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class SifreGuncelleme : Form
    {
        public SifreGuncelleme()
        {
            InitializeComponent();
        }

        private void btn_sifreguncelle_Click(object sender, EventArgs e)
        {
            SifreGuncelle guncelle = new SifreGuncelle();
            if (!guncelle.KullaniciAdKontrol(txt_kulad.Text))
            {
                MessageBox.Show("Bu Kullanıcı Adına Sahip Bir Kullanıcı Bulunmamaktadır.");
                txt_kulad.Text = "";
            }
            else
            {
                guncelle.Sifreguncelle(txt_kulad.Text, txt_yenisifre.Text);
                MessageBox.Show("Şifreniz Güncellendi.");
            }
            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_yenisifre.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_yenisifre.PasswordChar = '\0';
                txt_yenisifreonay.PasswordChar = '\0';
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_yenisifre.PasswordChar == '\0')
            {
                btn_show.BringToFront();
                txt_yenisifre.PasswordChar = '*';
                txt_yenisifreonay.PasswordChar = '*';
            }
        }
    }
}
