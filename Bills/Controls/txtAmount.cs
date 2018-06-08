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
    public partial class Amount : TextBox
    {
        public string SqlAmount = String.Empty;
        private int count = 0;

        public Amount()
        {
            InitializeComponent();
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            try
            {
                if (txt.Text.Length > 0)
                {
                    txt.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(txt.Text));
                    SqlAmount = Classes.MainHelper.DecimalForSql(Convert.ToDecimal(txt.Text));
                }
            }
            catch
            {

            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            try
            {
                if (txt.Text.Length > 0)
                {
                    txt.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(txt.Text));
                    SqlAmount = Classes.MainHelper.DecimalForSql(Convert.ToDecimal(txt.Text));
                }
            }
            catch
            {

            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == ',')
            {
                foreach (Char c in txtAmount.Text)
                {
                    if (c == ',') count++;
                }
                if (count >= 1)
                    e.Handled = true;
            }
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                //The char is not a number
                //Handle the event so the key press is ignored
                e.Handled = true;
            }
        }

        public void Refresh(object sender)
        {
            TextBox txt = sender as TextBox;
            try
            {
                if (txt.Text.Length > 0)
                {
                    SqlAmount = Classes.MainHelper.DecimalForSql(Convert.ToDecimal(txt.Text));
                    txt.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(txt.Text));
                }
            }
            catch
            {

            }
        }
    }
}
