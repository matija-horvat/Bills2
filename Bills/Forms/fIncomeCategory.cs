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
    public partial class fIncomeCategory : Form
    {
        #region Fields
        private bool dataIsBuild = false;
        private Classes.IncomeCategory incCat = null;
        #endregion

        #region Ctor
        public fIncomeCategory()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fIncomeCategory_Load(object sender, EventArgs e)
        {
            incCat = new Classes.IncomeCategory();
            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id");
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            incCat.Save(incCat);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fIncomeCategoryUpdate incCatU = new fIncomeCategoryUpdate(this.incCat, this);
            incCatU.MdiParent = this.MdiParent;
            incCatU.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            incCat.SetStatusId(incCat, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            incCat.SetStatusId(incCat, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            incCat.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            incCat.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                incCat.SetStatusId(incCat, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void dataIncomeCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataIncomeCategory.SelectedRows.Count > 0)
            {
                incCat.Id = System.Convert.ToInt32(dataIncomeCategory.Rows[dataIncomeCategory.CurrentRow.Index].Cells[3].Value.ToString());
                incCat = (Classes.IncomeCategory)(Helpers.ReaderHelper.SelectObjectOnId((object)incCat, "spIncomeCategory", 11, incCat.Id));
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
            Helpers.ReaderHelper.BindGrid(ref dataIncomeCategory, "spIncomeCategory", 1, "IncomeCategory");
            dataIncomeCategory.Columns[0].Width = 200;
            dataIncomeCategory.Columns[1].Width = 300;
        }

        private void ClearSurface()
        {
            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

    }
}
