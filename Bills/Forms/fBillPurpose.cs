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
    public partial class BillPurpose : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        private bool dataIsBuild = false;
        private Classes.BillPurpose billP = null;
        #endregion

        #region Ctor
        public BillPurpose()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void BillPurpose_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Form1.connString);
            billP = new Classes.BillPurpose();
            adapter = new SqlDataAdapter("select bp.name as [Namjena računa], bp.Description as Opis, s.name as Status, bp.id from BillPurpose bp left join status s on bp.statusid = s.id", conn);

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id"); 
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            billP.Save(billP);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fBillPurposeUpdate billPurp = new fBillPurposeUpdate(this.billP, this);
            billPurp.MdiParent = this.MdiParent;
            billPurp.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            billP.SetStatusId(billP, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            billP.SetStatusId(billP, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            billP.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            billP.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                billP.SetStatusId(billP, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void dataBillPurpose_SelectionChanged(object sender, EventArgs e)
        {
            if (dataBillPurpose.SelectedRows.Count > 0)
            {
                //billP = Helpers.ReaderHelper.SelectCategoryOnId("spBillPurpose", 11, System.Convert.ToInt32(dataBillPurpose.Rows[dataBillPurpose.CurrentRow.Index].Cells[3].Value.ToString()));
                billP.Id = System.Convert.ToInt32(dataBillPurpose.Rows[dataBillPurpose.CurrentRow.Index].Cells[3].Value.ToString());
                billP = (Classes.BillPurpose)(Helpers.ReaderHelper.SelectObjectOnId((object)billP, "spBillPurpose", 11, billP.Id));
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
            Helpers.ReaderHelper.RefreshGrid(ref dataBillPurpose, adapter, "BillPurpose");
            dataBillPurpose.Columns[0].Width = 250;
            dataBillPurpose.Columns[1].Width = 600;
            dataBillPurpose.Columns[2].Width = 150;
            
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
