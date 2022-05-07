using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class KullaniciBilgileri : Form
    {
        public KullaniciBilgileri()
        {
            InitializeComponent();

            Kullanici kul = new Kullanici();
            data_bilgi.Visible = false;
            data_bilgi.DataSource = kul.KulListele(Giris.kulad);
            txt_kulad.Text = data_bilgi.Rows[0].Cells[1].Value.ToString();
            txt_ad.Text = data_bilgi.Rows[0].Cells[2].Value.ToString();
            txt_soyad.Text= data_bilgi.Rows[0].Cells[3].Value.ToString();
            txt_mail.Text= data_bilgi.Rows[0].Cells[4].Value.ToString();

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
