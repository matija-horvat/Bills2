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
    public partial class Bill : Form
    {
        #region Fields
        SqlConnection conn = null;
        private Classes.BillHead head = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public Bill()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Bill_Load(object sender, EventArgs e)
        {
            head = new Classes.BillHead();
            conn = new SqlConnection(Form1.connString);

            Helpers.ReaderHelper.RefreshComboBox("select id, name from BillCategory where statusid = 1",ref cmbBillCategory, "BillCategory", "name", "id");
            Helpers.ReaderHelper.RefreshComboBox("select id, name from BillPurpose where statusid = 1", ref cmbBillPurpose, "BillPurpose", "name", "id");
            Helpers.ReaderHelper.RefreshComboBox("select id, name from Store where statusid = 1", ref cmbStore, "Store", "name", "id");
            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id"); 
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            head.Save(head);

            Forms.BillBody body = new BillBody(head);
            body.MdiParent = this.MdiParent;

            this.Close();

            body.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region UI Events
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            head.BillNumber = txtNumber.Text;
        }

        private void mtxtDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                head.BillDate = System.Convert.ToDateTime(mtxtDate.Text);
            }
            catch
            {

            }
        }

        private void cmbBillCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                head.SetCategoryId(head, ((DataRowView)cmbBillCategory.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void cmbBillPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                head.SetPurposeId(head, ((DataRowView)cmbBillPurpose.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                head.SetStoreId(head, ((DataRowView)cmbStore.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            head.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                head.SetStatusId(head, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
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

        #region Methods
       
        #endregion
    }
}
