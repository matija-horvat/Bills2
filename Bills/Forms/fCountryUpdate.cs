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
    public partial class fCountryUpdate : Form
    {
        #region Fields
        private Classes.Country country = null;
        private Forms.Country fCountry = null;
        #endregion

        #region Ctor
        public fCountryUpdate()
        {
            InitializeComponent();
        }

        public fCountryUpdate(Classes.Country countryU)
        {
            this.country = countryU;
            InitializeComponent();
        }

        public fCountryUpdate(Classes.Country countryU, Forms.Country fCountry)
        {
            this.country = countryU;
            this.fCountry = fCountry;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fCountryUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = country.Name;
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            country.Update(country);
            fCountry.UpdateHUD();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            country.Name = txtName.Text;
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox2.Size.Width - 3, groupBox2.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, groupBox2.Size.Width, groupBox2.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox2.Size.Width - 3, groupBox2.Size.Height - 5));

            linearGradientBrush.Dispose();
        }
        #endregion

    }
}
