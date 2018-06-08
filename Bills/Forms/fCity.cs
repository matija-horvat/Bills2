using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bills.Forms
{
    public partial class City : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;

        private bool dataIsBuild = false;

        private Classes.City city = null;
        #endregion

        #region Ctor
        public City()
        {
            InitializeComponent();
        }
        #endregion

        #region Form events
        private void City_Load(object sender, EventArgs e)
        {
            city = new Classes.City();
            conn = new SqlConnection(Form1.connString);
            adapter = new SqlDataAdapter("select c.name as [Grad],c.PONumber as [Poštanski broj], r.name as [Županija], c.id from city c left join region r on c.regionid = r.id", conn);

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Region", ref cmbRegion, "Region", "name", "id"); 
            RefreshGrid();
        }
        #endregion

        #region Button events
        private void btnSave_Click(object sender, EventArgs e)
        {
            city.Save(city);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fCityUpdate cityU = new fCityUpdate(this.city, this);
            cityU.MdiParent = this.MdiParent;
            cityU.Show();

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            city.SetStatusId(city, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            city.SetStatusId(city, "Inactive");
            RefreshGrid();
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

        private void dataGradovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGradovi.SelectedRows.Count > 0)
            {
                city.Id = System.Convert.ToInt32(dataGradovi.Rows[dataGradovi.CurrentRow.Index].Cells[3].Value.ToString());
                city = (Classes.City)(Helpers.ReaderHelper.SelectObjectOnId((object)city, "spCity", 11, city.Id));
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
            Helpers.ReaderHelper.RefreshGrid(ref dataGradovi, adapter, "City");
            dataGradovi.Columns[0].Width = 200;
            dataGradovi.Columns[1].Width = 100;
            dataGradovi.Columns[2].Width = 500;
        }

        private void ClearSurface()
        {
            txtName.Text = String.Empty;
            txtPOnumber.Text = String.Empty;
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

    }
}
