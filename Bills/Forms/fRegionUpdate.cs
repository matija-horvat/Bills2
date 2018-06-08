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
    public partial class fRegionUpdate : Form
    {
        #region Fields
        private Classes.Region region = null;
        private bool dataIsBuild = false;
        private Forms.Region fRegion = null;
        #endregion

        #region Ctor
        public fRegionUpdate()
        {
            InitializeComponent();
        }

        public fRegionUpdate(Classes.Region regionU)
        {
            this.region = regionU;
            InitializeComponent();
        }

        public fRegionUpdate(Classes.Region regionU, Forms.Region fRegion)
        {
            this.region = regionU;
            this.fRegion = fRegion;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fRegionUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = region.Name;
            Helpers.ReaderHelper.RefreshComboBox("select id, name from Country", ref cmbDrzava, "Country", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            region.Update(region);
            fRegion.UpdateHUD();//refresh grida
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
            region.Name = txtName.Text;
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                region.SetCountryId(region, ((DataRowView)cmbDrzava.SelectedItem).Row["name"].ToString());
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
