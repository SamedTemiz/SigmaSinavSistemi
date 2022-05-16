using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class SinavSiklikDuzeyi : Form
    {
        public SinavSiklikDuzeyi()
        {
            InitializeComponent();
        }

            
        private void SinavSiklikDuzeyi_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            Ayar s = new Ayar();
            if (radio_Az.Checked==true)
            {
                if (s.SinavDuzey(1))
                {
                    MessageBox.Show("Sıklık Düzeyi Güncellenemedi.");
                }
                else
                {
                    MessageBox.Show("Sıklık Düzeyi Güncellendi");
                }
                
            }
            else if (radio_Orta.Checked==true)
            {
                if (s.SinavDuzey(2))
                {
                    MessageBox.Show("Sıklık DÜzeyi Güncellenemedi.");
                }
                else
                {
                    MessageBox.Show("Sıklık Düzeyi Güncellendi");
                }

            }
            else if (radio_Cok.Checked==true)
            {
                if (s.SinavDuzey(3))
                {
                    MessageBox.Show("Sıklık Düzeyi Güncellendi");
                }
                else
                {
                    MessageBox.Show("Sıklık DÜzeyi Güncellenemedi.");
                }
            }

        }
    }
}
