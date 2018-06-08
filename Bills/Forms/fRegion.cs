using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Forms
{
    public partial class Region : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        
        private bool dataIsBuild = false;
        private Classes.Region region = null;
        #endregion

        #region Ctor
        public Region()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Region_Load(object sender, EventArgs e)
        {
            region = new Classes.Region();
            conn = new SqlConnection(Form1.connString);
            adapter = new SqlDataAdapter("select r.name as [Županija], c.name as [Država], r.id from region r left join country c on r.countryid = c.id", conn);

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Country", ref cmbDrzava, "Country", "name", "id"); 
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            region.Save(region);
            RefreshGrid();
            ClearSurface();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fRegionUpdate regionU = new fRegionUpdate(this.region, this);
            regionU.MdiParent = this.MdiParent;
            regionU.Show();

            //RefreshGrid();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            region.SetStatusId(region, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            region.SetStatusId(region, "Inactive");
            RefreshGrid();
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

        private void dataRegion_SelectionChanged(object sender, EventArgs e)
        {
            if (dataRegion.SelectedRows.Count > 0)
            {
                region.Id = System.Convert.ToInt32(dataRegion.Rows[dataRegion.CurrentRow.Index].Cells[2].Value.ToString());
                region = (Classes.Region)(Helpers.ReaderHelper.SelectObjectOnId((object)region, "spRegion", 11, region.Id));
            }
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

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox3.Size.Width - 3, groupBox3.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, groupBox3.Size.Width, groupBox3.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox3.Size.Width - 3, groupBox3.Size.Height - 5));

            linearGradientBrush.Dispose();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            Helpers.ReaderHelper.RefreshGrid(ref dataRegion, adapter, "Region");
            dataRegion.Columns[0].Width = 300;
            dataRegion.Columns[1].Width = 200;
        }

        private void ClearSurface()
        {
            txtName.Text = String.Empty;
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

    }
}
