using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Controls
{
    public partial class lblAmount : Label
    {
        public lblAmount()
        {
            InitializeComponent();
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            try
            {
                if (lbl.Text.Length > 0)
                {
                    lbl.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(lbl.Text));
                }
            }
            catch
            {

            }
        }

        private void Amount_Leave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            try
            {
                if (lbl.Text.Length > 0)
                {
                    lbl.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(lbl.Text));
                }
            }
            catch
            {

            }
        }
    }
}
