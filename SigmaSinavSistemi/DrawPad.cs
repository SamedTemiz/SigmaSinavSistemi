using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class DrawPad : Form
    {
        public Point current = new Point();
        public Point old = new Point();

        public Graphics g;
        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);
        Bitmap surface;

        public DrawPad()
        {
            InitializeComponent();

            g = pnl_canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(pnl_canvas.Width, pnl_canvas.Height);

            graph = Graphics.FromImage(surface);

            pnl_canvas.BackgroundImage = surface;
            pnl_canvas.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)num_size.Value;

            pic_brush.Image = Properties.Resources.brush_p;
        }

        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }
        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);

                old = current;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_brush_Click(object sender, EventArgs e) //Fırça
        {
            pen.Color = pic_color.BackColor;
            pic_brush.Image = Properties.Resources.brush_p;
            pic_eraser.Image = Properties.Resources.eraser;
        }

        private void pic_eraser_Click(object sender, EventArgs e) //Silgi
        {
            pen.Color = Color.FromArgb(243, 236, 233);//Silgi rengi
            pic_eraser.Image = Properties.Resources.eraser_p;
            pic_brush.Image = Properties.Resources.brush;
        }

        private void pic_color_Click(object sender, EventArgs e)//Renk seçici
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
                pic_color.BackColor = cd.Color;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)//Sayfayı temizleme
        {

        }

        private void num_size_ValueChanged(object sender, EventArgs e)//Fırça boyutu
        {
            pen.Width = (float)num_size.Value;
        }

        Point lastPoint;
        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_cleaner_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.FromArgb(243,236,233));//Arka plan rengi
            pnl_canvas.Invalidate();
        }
    }
}
