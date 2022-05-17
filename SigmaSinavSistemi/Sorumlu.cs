using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class Sorumlu : Form
    {
        public static int SoruAdet { get; set; }
        public static int Sure { get; set; }
        Database db = new Database();
        SoruHavuzu sorular = new SoruHavuzu();
        public Sorumlu()
        {
            db.Baglan();
            InitializeComponent();
            SinavAyar();
            num_adet.Value = SoruAdet;
            num_sure.Value = Sure;

            lbl_Tarih.Text = DateTime.Now.ToString("dd MMMM dddd | yyyy");
            tabPage1.Text = "Soru Havuzu";
            tabPage2.Text = "Soru Listele";
            SoruListele();
            data_Sorular.Columns[0].HeaderText = "ID";
            data_Sorular.Columns[0].Width = 45;

            data_Sorular.Columns[1].HeaderText = "KONU ID";
            data_Sorular.Columns[1].Width = 70;

            data_Sorular.Columns[2].HeaderText = "KONU ADI";
            data_Sorular.Columns[2].Width = 250;

            data_Sorular.Columns[3].HeaderText = "GÖRSEL";
            data_Sorular.Columns[3].Width = 200;

            data_Sorular.Columns[4].HeaderText = "SEVİYE";
            data_Sorular.Columns[4].Width = 60;

            data_Sorular.Columns[5].HeaderText = "DOĞRU CEVAP";
            data_Sorular.Columns[5].Width = 100;

            foreach (DataGridViewColumn item in data_Sorular.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        public void SoruListele()
        {
            data_Sorular.DataSource = sorular.Listele(0);
            txt_sorusay.Text = sorular.Listele(0).Count.ToString();
        }
        public void SinavAyar()
        {
            db.Baglan();
            db.cmd = new SqlCommand("SELECT Sure, SoruAdet FROM SinavAyar", db.conn);
            db.conn.Open();
            var oku = db.cmd.ExecuteReader();
            while(oku.Read())
            {
                Sure = int.Parse(oku[0].ToString());
                SoruAdet = int.Parse(oku[1].ToString());
            }
            db.conn.Close();
        }
        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            string imagefile = Path.GetFileName(pic_soru.ImageLocation);
            string imagepath = Path.Combine(Application.StartupPath + "\\soru\\" + imagefile);
            if (!File.Exists(imagepath))
            {
                File.Copy(pic_soru.ImageLocation, imagepath, true);
                SoruHavuzu soru = new SoruHavuzu();
                soru.GorselAd = txt_gozat.Text;
                soru.KonuId = cmb_konu.SelectedIndex + 1;
                soru.Seviye = cmb_seviye.Text;
                soru.DogruCevap = cmb_dogru.SelectedIndex + 1;
                MessageBox.Show(soru.SoruEkle());
                txt_gozat.Text = "";
                cmb_dogru.Text = "--Seçin--";
                cmb_konu.Text = "--Seçin--";
                cmb_seviye.Text = "--Seçin---";
                pic_soru.Image = null;
            }
            else
            {
                MessageBox.Show("Bu soru zaten havuzda");
                txt_gozat.Text = "";
                cmb_dogru.Text = "--Seçin--";
                cmb_konu.Text = "--Seçin--";
                cmb_seviye.Text = "--Seçin---";
            }
            SoruListele();
        }
        private void btn_gozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            resimsec.Title = "Resim Seç";
            resimsec.Filter = "Image Files | *.jpg; *.jpeg; *.png; *";
            if (resimsec.ShowDialog() == DialogResult.OK)
            {
                pic_soru.ImageLocation = resimsec.FileName;
            }
            txt_gozat.Text = Path.GetFileName(resimsec.FileName);
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int konuid = cmb_gkonu.SelectedIndex + 1;
            string Seviye = cmb_gseviye.Text;
            string DogruCevap = cmb_gDogru.Text;
            int Id = int.Parse(data_Sorular.CurrentRow.Cells[0].Value.ToString());

            sorular.Guncelle(Id, konuid, Seviye, DogruCevap);

            MessageBox.Show("Seçilen soru güncellenmiştir.");
            cmb_gDogru.Text = "--Seçin--";
            cmb_gkonu.Text = "--Seçin--";
            cmb_gseviye.Text = "--Seçin--";
            cmb_listeleme.Text = "--Seçin--";
            txt_Id.Text = "";
            data_Sorular.ClearSelection();
            SoruListele();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(data_Sorular.CurrentRow.Cells[0].Value.ToString());
            string imagefile = Path.GetFileName(pic_soru.ImageLocation);
            string uzanti = Path.Combine(Application.StartupPath + "\\soru\\" + imagefile);
            sorular.Sil(Id);
            if (System.IO.File.Exists(uzanti))
            {
                System.IO.File.Delete(uzanti);
            }
            
            MessageBox.Show("Seçilen soru silinmiştir.");
            cmb_gDogru.Text = "--Seçin--";
            cmb_gkonu.Text = "--Seçin--";
            cmb_gseviye.Text = "--Seçin--";
            cmb_listeleme.Text = "--Seçin--";
            txt_Id.Text = "";
            data_Sorular.ClearSelection();
            SoruListele();
        }
        private void cmb_listeleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_Sorular.DataSource = sorular.Listele(cmb_listeleme.SelectedIndex + 1);
        }
        private void btn_tumunugoster_Click(object sender, EventArgs e)
        {
            cmb_listeleme.Text = "--Seçin--";
            SoruListele();
        }
        private void data_Sorular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Sorular.SelectedRows.Count > 1)
            {
                MessageBox.Show("Sadece Bir Soru Seçebilirsiniz.");
                data_Sorular.ClearSelection();
            }
            else
            {
                txt_Id.Text = data_Sorular.CurrentRow.Cells[0].Value.ToString();
                cmb_gkonu.Text = data_Sorular.CurrentRow.Cells[2].Value.ToString();
                cmb_gseviye.Text = data_Sorular.CurrentRow.Cells[4].Value.ToString();
                cmb_gDogru.Text = data_Sorular.CurrentRow.Cells[5].Value.ToString();
            }
        }
        private void data_Sorular_SelectionChanged(object sender, EventArgs e)
        {
            txt_Id.Text = data_Sorular.CurrentRow.Cells[0].Value.ToString();
            cmb_gkonu.SelectedIndex = int.Parse(data_Sorular.CurrentRow.Cells[1].Value.ToString()) - 1;
            cmb_gseviye.SelectedItem = data_Sorular.CurrentRow.Cells[4].Value.ToString();
            cmb_gDogru.SelectedIndex = int.Parse(data_Sorular.CurrentRow.Cells[5].Value.ToString()) - 1;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_onay_Click(object sender, EventArgs e)
        {
            int sure = int.Parse(num_sure.Value.ToString());
            int adet = int.Parse(num_adet.Value.ToString());

            db.cmd = new SqlCommand("UPDATE SinavAyar SET Sure = '" + sure + "', SoruAdet = '" + adet + "' ", db.conn);
            db.conn.Open();
            if(db.cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("İşlem başarılı...");
            }
            else
            {
                MessageBox.Show("HATA!");
            }
            db.conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sure.ToString() + " " + SoruAdet.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void data_Sorular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
