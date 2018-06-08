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
    public partial class fCityUpdate : Form
    {
        #region Fields
        private Classes.City city = null;
        private Forms.City fCity = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public fCityUpdate()
        {
            InitializeComponent();
        }

        public fCityUpdate(Classes.City city)
        {
            this.city = city;
            InitializeComponent();
        }

        public fCityUpdate(Classes.City city, Forms.City fCity)
        {
            //fCity is form City
            this.city = city;
            this.fCity = fCity;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fCityUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = city.Name;
            txtPOnumber.Text = city.PoNumber;

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Region", ref cmbRegion, "Region", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            city.Update(city);
            fCity.UpdateHUD();
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
            city.Name = txtName.Text;
        }

        private void txtPOnumber_TextChanged(object sender, EventArgs e)
        {
            city.PoNumber = txtPOnumber.Text;
        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                city.SetRegionId(city, ((DataRowView)cmbRegion.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
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
