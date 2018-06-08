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
    public partial class BillBody : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        
        private bool dataIsBuild = false;

        private Classes.BillHead head = null;
        private Classes.BillBody body = null;
        #endregion

        #region Ctor
        public BillBody()
        {
            InitializeComponent();
        }

        public BillBody(Classes.BillHead head)
        {
            this.head = head;
            
            InitializeComponent();

            
        }
        #endregion

        #region Form Events
        private void BillBody_Load(object sender, EventArgs e)
        {
            body = new Classes.BillBody();
            conn = new SqlConnection(Form1.connString);

            //adapter = new SqlDataAdapter("select articlname as [Artikl / Usluga], Quantity as [Količina], uom.name as [Jedinica mjere], sum as [Iznos (kn)], PDV, b.description as [Napomena], b.id from billbody b inner join UnitOfMeasure uom on b.UnitOfMeasureID = uom.id where b.billhead = " + this.head.Id.ToString(), conn);
            Helpers.ReaderHelper.RefreshComboBox("select id, name from UnitOfMeasure where statusid = 1", ref cmbUoM, "UnitOfMeasure", "name", "id");

            this.Text = "Stavke računa: " + this.head.BillNumber;
            //label1.Text = this.head.Id.ToString();

            txtNumber.Text = head.BillNumber;
            mtxtDate.Text = head.BillDate.ToShortDateString();
            txtStore.Text = Classes.MainHelper.GetOneValue("select name from store where id = " + head.StoreID.ToString());
            txtBillCategory.Text = Classes.MainHelper.GetOneValue("select name from BillCategory where id = " + head.BillCategoryID.ToString());
            txtBillPurpose.Text = Classes.MainHelper.GetOneValue("select name from BillPurpose where id = " + head.BillPurposeID.ToString());
            txtSumTotal.Text = head.TotalSum.ToString();
            txtSumTotal.Refresh(txtSumTotal);
            txtSumTotal.Refresh();
            txtPdvTotal.Text = head.TotalPdv.ToString();
            RefreshGrid();
            txtArticl.Focus();
        }
        #endregion

        #region Button Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            head.StatusID = System.Convert.ToInt32(Classes.MainHelper.GetOneValue("select statusid from billhead where id = " + head.Id.ToString()));
            head.TotalSum = System.Convert.ToDecimal(Classes.MainHelper.GetOneValue("select coalesce((select sum(sum)),0) from billbody where billhead = " + head.Id.ToString()));
            head.TotalPdv = System.Convert.ToDecimal(Classes.MainHelper.GetOneValue("select coalesce((select sum(pdv)),0) from billbody where billhead = " + head.Id.ToString()));

            Helpers.NonQueryHelper.Update(head, "spBillInsert", 2);

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            body.HeadId = head.Id;
            body.Save(body);

            txtSumTotal.Text = Classes.MainHelper.GetOneValue("select coalesce((sum(sum)),0) from billbody where billhead = " + head.Id.ToString());
            txtPdvTotal.Text = Classes.MainHelper.GetOneValue("select coalesce((sum(pdv)),0) from billbody where billhead = " + head.Id.ToString());

            RefreshGrid();
            ClearSurface();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            Helpers.ReaderHelper.BindBillBodyOnId("spBillQuery", 2, this.head.Id, ref dataBody, "BillBody");
            //Helpers.ReaderHelper.RefreshGrid(ref dataBody, adapter, "BillBody");
            dataBody.Columns[0].Width = 200;
            dataBody.Columns[1].Width = 100;
            dataBody.Columns[2].Width = 100;
            dataBody.Columns[3].Width = 150;
            dataBody.Columns[4].Width = 100;
            dataBody.Columns[5].Width = 250;
        }

        private void ClearSurface()
        {
            txtArticl.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtSum.Text = String.Empty;
            txtPDV.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtArticl.Focus();
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

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox3.Size.Width - 3, groupBox3.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, groupBox3.Size.Width, groupBox3.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox3.Size.Width - 3, groupBox3.Size.Height - 5));

            linearGradientBrush.Dispose();
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox4.Size.Width - 3, groupBox4.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, groupBox4.Size.Width, groupBox4.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox4.Size.Width - 3, groupBox4.Size.Height - 5));

            linearGradientBrush.Dispose();
        }
        #endregion

        
       
        
    }
}
