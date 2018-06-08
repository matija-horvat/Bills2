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
    public partial class fBillPurposeUpdate : Form
    {
        #region Fields
        private Classes.BillPurpose billP = null;
        private Forms.BillPurpose fBillP = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public fBillPurposeUpdate()
        {
            InitializeComponent();
        }

        public fBillPurposeUpdate(Classes.BillPurpose billPurp)
        {
            this.billP = billPurp;
            InitializeComponent();
        }

        public fBillPurposeUpdate(Classes.BillPurpose billPurp, Forms.BillPurpose fBillPurp)
        {
            this.billP = billPurp;
            this.fBillP = fBillPurp;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fBillPurposeUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = billP.Name;
            txtDescription.Text = billP.Description;

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            billP.Update(billP);
            fBillP.UpdateHUD();
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
