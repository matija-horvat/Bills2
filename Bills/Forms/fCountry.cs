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
    public partial class Country : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        
        private Classes.Country country = null;
        #endregion

        #region Ctor
        public Country()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Country_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            country = new Classes.Country();
            conn = new SqlConnection(Form1.connString);
            adapter = new SqlDataAdapter("select name as [Naziv države], id from country", conn);

            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            country.Save(country);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fCountryUpdate countryU = new fCountryUpdate(this.country, this);
            countryU.MdiParent = this.MdiParent;
            countryU.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            country.SetStatusId(country, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            country.SetStatusId(country, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            country.Name = txtName.Text;
        }

        private void dataCountry_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCountry.SelectedRows.Count > 0)
            {
                country.Id = System.Convert.ToInt32(dataCountry.Rows[dataCountry.CurrentRow.Index].Cells[1].Value.ToString());
                country = (Classes.Country)(Helpers.ReaderHelper.SelectObjectOnId((object)country, "spCountry", 11, country.Id));
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
            Helpers.ReaderHelper.RefreshGrid(ref dataCountry, adapter, "Country");
            dataCountry.Columns[0].Width = 300;
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
