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
    public partial class BillBodyUpdate : Form
    {
        #region Fields
        private bool dataIsBuild = false;
        private Classes.BillHead head = null;
        private Classes.BillBody body = null;
        #endregion

        #region Ctor
        public BillBodyUpdate()
        {
            InitializeComponent();
        }

        public BillBodyUpdate(Classes.BillHead head)
        {
            this.head = head;
            
            InitializeComponent();

        }

        public BillBodyUpdate(Classes.BillHead head, Classes.BillBody body)
        {
            this.head = head;
            this.body = body;
            InitializeComponent();

        }
        #endregion

        #region Form Events
        private void BillBodyUpdate_Load(object sender, EventArgs e)
        {
            txtArticl.Text = body.Articl;
            txtQuantity.Text = body.Quantity.ToString();
            txtSum.Text = body.Sum.ToString();
            txtPDV.Text = body.Pdv.ToString();
            txtDescription.Text = body.Description;

            Helpers.ReaderHelper.RefreshComboBox("select id, name from UnitOfMeasure where statusid = 1", ref cmbUoM, "UnitOfMeasure", "name", "id");

        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            body.HeadId = head.Id;
            Helpers.NonQueryHelper.Update(body, "spBillInsert", 3);

            head.StatusID = System.Convert.ToInt32(Classes.MainHelper.GetOneValue("select statusid from billhead where id = " + head.Id.ToString()));
            head.TotalSum = System.Convert.ToDecimal(Classes.MainHelper.GetOneValue("select sum(sum) from billbody where billhead = " + head.Id.ToString()));
            head.TotalPdv = System.Convert.ToDecimal(Classes.MainHelper.GetOneValue("select sum(pdv) from billbody where billhead = " + head.Id.ToString()));

            Helpers.NonQueryHelper.Update(head, "spBillInsert", 2);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region UI Events
        private void txtArticl_TextChanged(object sender, EventArgs e)
        {
            body.Articl = txtArticl.Text;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                body.Quantity = System.Convert.ToDecimal(txtQuantity.Text);
            }
            catch
            {

            }
        }

        private void cmbUoM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                body.SetUomId(body, ((DataRowView)cmbUoM.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                body.Sum = System.Convert.ToDecimal(txtSum.Text);
                txtPDV.Text = (body.Sum / 4).ToString();
            }
            catch
            {

            }
        }

        private void txtPDV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                body.Pdv = System.Convert.ToDecimal(txtPDV.Text);
            }
            catch
            {

            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            body.Description = txtDescription.Text;
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
