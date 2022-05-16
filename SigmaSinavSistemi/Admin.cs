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
    public partial class Admin : Form
    {
        Kullanici kul = new Kullanici();
        DataSet ds = new DataSet();
        SoruHavuzu sorular = new SoruHavuzu();

        public Admin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            kullaniciListele();
            dataKul.Columns[0].HeaderText = "ID";
            dataKul.Columns[0].Width = 47;

            dataKul.Columns[1].HeaderText = "KULLANICI ADI";
            dataKul.Columns[1].Width = 150;

            dataKul.Columns[2].HeaderText = "ADI";
            dataKul.Columns[2].Width = 150;

            dataKul.Columns[3].HeaderText = "SOYADI";
            dataKul.Columns[3].Width = 150;

            dataKul.Columns[4].HeaderText = "MAİL";
            dataKul.Columns[4].Width = 250;

            dataKul.Columns[5].HeaderText = "ŞİFRE";
            dataKul.Columns[5].Width = 50;

            dataKul.Columns[6].HeaderText = "KULLANICI ID";
            dataKul.Columns[6].Width = 131;

            foreach (DataGridViewColumn item in dataKul.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //------------------------------------------------------------------------------
            lbltarih.Text = DateTime.Now.ToString("dd MMMM dddd | yyyy");
            tabPage1.Text = "Kullanıcılar";
            tabPage2.Text = "Sorular";
            SoruListele1();
            datasorularadmin.Columns[0].HeaderText = "ID";
            datasorularadmin.Columns[0].Width = 45;

            datasorularadmin.Columns[1].HeaderText = "KONU ID";
            datasorularadmin.Columns[1].Width = 70;

            datasorularadmin.Columns[2].HeaderText = "KONU ADI";
            datasorularadmin.Columns[2].Width = 250;

            datasorularadmin.Columns[3].HeaderText = "GÖRSEL";
            datasorularadmin.Columns[3].Width = 200;

            datasorularadmin.Columns[4].HeaderText = "SEVİYE";
            datasorularadmin.Columns[4].Width = 60;

            datasorularadmin.Columns[5].HeaderText = "DOĞRU CEVAP";
            datasorularadmin.Columns[5].Width = 100;

            datasorularadmin.Columns[8].HeaderText = "ONAY";
            datasorularadmin.Columns[8].Width = 100;

            txtssayısı.Text = sorular.Listele(0).Count.ToString();

            foreach (DataGridViewColumn item in datasorularadmin.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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

        public void SoruListele1()
        {
            datasorularadmin.DataSource = sorular.Listele(0);
        }

        private void Admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            kullaniciListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //ds.Tables["dbo.kullanicilar"].Clear();
            Kullanici Kul = new Kullanici();
            Kul.KullaniciAd = txtKulAd.Text;
            Kul.Ad = txtAd.Text;
            Kul.Soyad = txtSoyad.Text;
            Kul.Mail = txtMail.Text;
            Kul.Sifre = txtSifre.Text;
            Kul.KullaniciTipID = combo_kultip.SelectedIndex;
            kul.ekleKullanici(Kul);
            txtId.Text = "";
            txtKulAd.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            dataKul.ClearSelection();
            kullaniciListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //ds.Tables["dbo.kullanicilar"].Clear();
            string kulad = txtKulAd.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string mail = txtMail.Text;
            string sifre = txtSifre.Text;
            int kul_tip = int.Parse(combo_kultip.SelectedIndex.ToString() + 1);
            int Id = int.Parse(dataKul.CurrentRow.Cells[0].Value.ToString());

            kul.KullaniciGuncelle(Id, kulad, ad, soyad, mail, sifre, kul_tip);

            MessageBox.Show("Seçilen Kullanici güncellenmiştir.");
            txtId.Text = "";
            txtKulAd.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            dataKul.ClearSelection();
            kullaniciListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataKul.CurrentRow.Cells[0].Value.ToString());
            kul.KullaniciSil(id);

            MessageBox.Show("Seçilen kullanıcı silinmiştir.");
            txtId.Text = "";
            txtKulAd.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            dataKul.ClearSelection();
            kullaniciListele();
        }

        private void dataKul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataKul.CurrentRow.Cells[0].Value.ToString();
            txtKulAd.Text = dataKul.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataKul.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataKul.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dataKul.CurrentRow.Cells[4].Value.ToString();
            txtSifre.Text = dataKul.CurrentRow.Cells[5].Value.ToString();
            combo_kultip.SelectedIndex = int.Parse(dataKul.CurrentRow.Cells[6].Value.ToString()) - 1;
        }
        public void kullaniciListele()
        {
            dataKul.DataSource = kul.KulListeleA();
        }

        private void lblonay_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsguncelle_Click(object sender, EventArgs e)
        {
            int konuid = cmbkonu.SelectedIndex + 1;
            string Seviye = cmbseviye.Text;
            string DogruCevap = cmbdcevap.Text;
            int Id = int.Parse(datasorularadmin.CurrentRow.Cells[0].Value.ToString());
            int onay = cmbonay.SelectedIndex ;

            sorular.GuncelleOnay(Id, konuid, Seviye, DogruCevap, onay);

            MessageBox.Show("Seçilen soru güncellenmiştir.");
            cmbdcevap.Text = "--Seçin--";
            cmbkonu.Text = "--Seçin--";
            cmbseviye.Text = "--Seçin--";
            cmbliste.Text = "--Seçin--";
            txtsoruıd.Text = "";
            cmbonay.Text= "--Seçin--";
            datasorularadmin.ClearSelection();
            SoruListele1();
            txtssayısı.Text = sorular.Listele(0).Count.ToString();
        }

        private void cmbliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            datasorularadmin.DataSource = sorular.Listele(cmbliste.SelectedIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbliste.Text = "--Seçin--";
            SoruListele1();
        }
        

        private void datasorularadmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtsoruıd.Text = datasorularadmin.CurrentRow.Cells[0].Value.ToString();
            cmbkonu.Text = datasorularadmin.CurrentRow.Cells[2].Value.ToString();
            cmbseviye.Text = datasorularadmin.CurrentRow.Cells[4].Value.ToString();
            cmbdcevap.Text = datasorularadmin.CurrentRow.Cells[5].Value.ToString();
            cmbonay.Text = datasorularadmin.CurrentRow.Cells[7].Value.ToString();
        }

        private void datasorularadmin_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (datasorularadmin.SelectedRows.Count > 1)
            {
                MessageBox.Show("Sadece Bir Soru Seçebilirsiniz.");
                datasorularadmin.ClearSelection();
            }
            else
            {
                txtsoruıd.Text = datasorularadmin.CurrentRow.Cells[0].Value.ToString();
                cmbkonu.Text = datasorularadmin.CurrentRow.Cells[2].Value.ToString();
                cmbseviye.Text = datasorularadmin.CurrentRow.Cells[4].Value.ToString();
                cmbdcevap.Text = datasorularadmin.CurrentRow.Cells[5].Value.ToString();
                cmbonay.Text = datasorularadmin.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void dataKul_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataKul.SelectedRows.Count > 1)
            {
                MessageBox.Show("Sadece Bir Kullanıcı Seçebilirsiniz.");
                dataKul.ClearSelection();
            }
            else
            {
                txtId.Text = dataKul.CurrentRow.Cells[0].Value.ToString();
                txtKulAd.Text = dataKul.CurrentRow.Cells[1].Value.ToString();
                txtAd.Text = dataKul.CurrentRow.Cells[2].Value.ToString();
                txtSoyad.Text = dataKul.CurrentRow.Cells[3].Value.ToString();
                txtMail.Text = dataKul.CurrentRow.Cells[4].Value.ToString();
                txtSifre.Text = dataKul.CurrentRow.Cells[5].Value.ToString();
                combo_kultip.Text = dataKul.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void datasorularadmin_SelectionChanged(object sender, EventArgs e)
        {
            txtsoruıd.Text = datasorularadmin.CurrentRow.Cells[0].Value.ToString();
            cmbkonu.SelectedIndex = int.Parse(datasorularadmin.CurrentRow.Cells[1].Value.ToString()) - 1;
            cmbseviye.SelectedItem = datasorularadmin.CurrentRow.Cells[4].Value.ToString();
            cmbdcevap.SelectedIndex = int.Parse(datasorularadmin.CurrentRow.Cells[5].Value.ToString()) - 1;
           // cmbonay.SelectedIndex = bool.Parse(datasorularadmin.CurrentRow.Cells[8].Value.ToString());
        }

        private void cmbonay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
