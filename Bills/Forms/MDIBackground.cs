using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Forms
{
    public partial class MDIBackground : Form
    {
        public MDIBackground()
        {
            InitializeComponent();
        }

        private void MDIBackground_Load(object sender, EventArgs e)
        {
            this.Location = new Point(1, 1);
            this.Size = new Size(this.MdiParent.Size.Width - 26, this.MdiParent.Height - 107);
            lblDesign.Location = new Point(this.Size.Width - 230, this.Size.Height - 50);
            lblTroskovnik.Location = new Point(this.Size.Width - 170, this.Size.Height - 80);
        }

        private void MDIBackground_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, this.Size.Width - 3, this.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, this.Size.Width, this.Size.Height), Color.FromArgb(47, 79, 79), Color.FromArgb(204, 219, 240), 45);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, this.Size.Width - 3, this.Size.Height - 5));

            linearGradientBrush.Dispose();
        }
    }
}
