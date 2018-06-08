using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Bills.Forms
{
    public partial class fIncomePaymen : Form
    {
        #region Fields
        private bool dataIsBuild = false;
        private Classes.IncomePaymen incPay = null;
        #endregion

        #region Ctor
        public fIncomePaymen()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fIncomePaymen_Load(object sender, EventArgs e)
        {
            incPay = new Classes.IncomePaymen();
            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id");
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            incPay.Save(incPay);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fIncomePaymenUpdate incPayU = new fIncomePaymenUpdate(this.incPay, this);
            incPayU.MdiParent = this.MdiParent;
            incPayU.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            incPay.SetStatusId(incPay, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            incPay.SetStatusId(incPay, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            incPay.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            incPay.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                incPay.SetStatusId(incPay, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void dataIncomePaymen_SelectionChanged(object sender, EventArgs e)
        {
            if (dataIncomePaymen.SelectedRows.Count > 0)
            {
                incPay.Id = System.Convert.ToInt32(dataIncomePaymen.Rows[dataIncomePaymen.CurrentRow.Index].Cells[3].Value.ToString());
                incPay = (Classes.IncomePaymen)(Helpers.ReaderHelper.SelectObjectOnId((object)incPay, "spIncomePaymen", 11, incPay.Id));
            }
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox2.Size.Width - 3, groupBox2.Size.Height - 5));

            Brush linearGradientBrush = new LinearGradientBrush(
               new Rectangle(0, 0, groupBox2.Size.Width, groupBox2.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox2.Size.Width - 3, groupBox2.Size.Height - 5));

            linearGradientBrush.Dispose();
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox3.Size.Width - 3, groupBox3.Size.Height - 5));

            Brush linearGradientBrush = new LinearGradientBrush(
               new Rectangle(0, 0, groupBox3.Size.Width, groupBox3.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox3.Size.Width - 3, groupBox3.Size.Height - 5));

            linearGradientBrush.Dispose();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            Helpers.ReaderHelper.BindGrid(ref dataIncomePaymen, "spIncomePaymen", 1, "IncomePaymen");
            dataIncomePaymen.Columns[0].Width = 200;
            dataIncomePaymen.Columns[1].Width = 300;
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
