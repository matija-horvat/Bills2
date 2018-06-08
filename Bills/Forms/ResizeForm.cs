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
    public partial class ResizeForm : Form
    {
        public ResizeForm()
        {
            InitializeComponent();
        }

        private void ResizeForm_Load(object sender, EventArgs e)
        {

        }

        private void ResizeForm_SizeChanged(object sender, EventArgs e)
        {
            this.Font = new Font(FontFamily.GenericSansSerif, ClientRectangle.Width / 70);
        }
    }
}
