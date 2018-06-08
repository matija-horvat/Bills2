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
    public partial class BillCategory : Form
    {
        #region Fields
        private bool dataIsBuild = false;
        private Classes.BillCategory billC = null;
        #endregion

        #region Ctor
        public BillCategory()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void BillCategory_Load(object sender, EventArgs e)
        {
            billC = new Classes.BillCategory();
            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id"); 
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            billC.Save(billC);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            billC.Id = (int)dataBillCategory.Rows[dataBillCategory.CurrentRow.Index].Cells[1].Value;
            billC.Delete(billC);
            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fBillCategoryUpdate billCat = new fBillCategoryUpdate(this.billC, this);
            billCat.MdiParent = this.MdiParent;
            billCat.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            billC.SetStatusId(billC, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            billC.SetStatusId(billC, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            billC.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            billC.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                billC.SetStatusId(billC, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void dataBillCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataBillCategory.SelectedRows.Count > 0)
            {
                billC.Id = System.Convert.ToInt32(dataBillCategory.Rows[dataBillCategory.CurrentRow.Index].Cells[3].Value.ToString());
                billC = (Classes.BillCategory)(Helpers.ReaderHelper.SelectObjectOnId((object)billC, "spBillCategory", 11, billC.Id));
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
            Helpers.ReaderHelper.BindGrid(ref dataBillCategory, "spBillCategory", 1, "BillCategory");
            dataBillCategory.Columns[0].Width = 200;
            dataBillCategory.Columns[1].Width = 300;
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
