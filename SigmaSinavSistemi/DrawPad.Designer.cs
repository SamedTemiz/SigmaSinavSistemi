
namespace SigmaSinavSistemi
{
    partial class DrawPad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawPad));
            this.pic_brush = new System.Windows.Forms.PictureBox();
            this.pic_eraser = new System.Windows.Forms.PictureBox();
            this.num_size = new System.Windows.Forms.NumericUpDown();
            this.pic_color = new System.Windows.Forms.PictureBox();
            this.pnl_side = new System.Windows.Forms.Panel();
            this.pic_cleaner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_canvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_brush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_color)).BeginInit();
            this.pnl_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cleaner)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_brush
            // 
            this.pic_brush.BackColor = System.Drawing.Color.Transparent;
            this.pic_brush.Image = global::SigmaSinavSistemi.Properties.Resources.brush;
            this.pic_brush.Location = new System.Drawing.Point(3, 6);
            this.pic_brush.Name = "pic_brush";
            this.pic_brush.Size = new System.Drawing.Size(40, 40);
            this.pic_brush.TabIndex = 2;
            this.pic_brush.TabStop = false;
            this.pic_brush.Click += new System.EventHandler(this.pic_brush_Click);
            // 
            // pic_eraser
            // 
            this.pic_eraser.Image = global::SigmaSinavSistemi.Properties.Resources.eraser;
            this.pic_eraser.Location = new System.Drawing.Point(3, 164);
            this.pic_eraser.Name = "pic_eraser";
            this.pic_eraser.Size = new System.Drawing.Size(40, 40);
            this.pic_eraser.TabIndex = 3;
            this.pic_eraser.TabStop = false;
            this.pic_eraser.Click += new System.EventHandler(this.pic_eraser_Click);
            // 
            // num_size
            // 
            this.num_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.num_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num_size.ForeColor = System.Drawing.Color.White;
            this.num_size.Location = new System.Drawing.Point(3, 52);
            this.num_size.Name = "num_size";
            this.num_size.Size = new System.Drawing.Size(40, 29);
            this.num_size.TabIndex = 4;
            this.num_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_size.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_size.ValueChanged += new System.EventHandler(this.num_size_ValueChanged);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(3, 87);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(40, 40);
            this.pic_color.TabIndex = 5;
            this.pic_color.TabStop = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // pnl_side
            // 
            this.pnl_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(152)))));
            this.pnl_side.Controls.Add(this.pic_cleaner);
            this.pnl_side.Controls.Add(this.pic_color);
            this.pnl_side.Controls.Add(this.num_size);
            this.pnl_side.Controls.Add(this.pic_eraser);
            this.pnl_side.Controls.Add(this.pic_brush);
            this.pnl_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_side.Location = new System.Drawing.Point(0, 35);
            this.pnl_side.Name = "pnl_side";
            this.pnl_side.Size = new System.Drawing.Size(47, 265);
            this.pnl_side.TabIndex = 0;
            // 
            // pic_cleaner
            // 
            this.pic_cleaner.AccessibleDescription = "TEMİZLE";
            this.pic_cleaner.Image = ((System.Drawing.Image)(resources.GetObject("pic_cleaner.Image")));
            this.pic_cleaner.Location = new System.Drawing.Point(4, 213);
            this.pic_cleaner.Name = "pic_cleaner";
            this.pic_cleaner.Size = new System.Drawing.Size(40, 40);
            this.pic_cleaner.TabIndex = 6;
            this.pic_cleaner.TabStop = false;
            this.pic_cleaner.Click += new System.EventHandler(this.pic_cleaner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÇİZİM PANELİ";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pnl_top.Controls.Add(this.button1);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(600, 35);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(569, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(233)))));
            this.pnl_canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_canvas.Location = new System.Drawing.Point(0, 35);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(600, 265);
            this.pnl_canvas.TabIndex = 1;
            this.pnl_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseDown);
            this.pnl_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseMove);
            // 
            // DrawPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.pnl_side);
            this.Controls.Add(this.pnl_canvas);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sigma Sınav Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pic_brush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_color)).EndInit();
            this.pnl_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cleaner)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_brush;
        private System.Windows.Forms.PictureBox pic_eraser;
        private System.Windows.Forms.NumericUpDown num_size;
        private System.Windows.Forms.PictureBox pic_color;
        private System.Windows.Forms.Panel pnl_side;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_canvas;
        private System.Windows.Forms.PictureBox pic_cleaner;
    }
}