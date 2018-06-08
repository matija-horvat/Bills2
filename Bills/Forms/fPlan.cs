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
    public partial class fPlan : Form
    {
        #region Fields
        private bool dataIsBuild = false;
        private Classes.Plan plan = null;
        #endregion

        #region Ctor
        public fPlan()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fPlan_Load(object sender, EventArgs e)
        {
            plan = new Classes.Plan();
            mtxtDate.Text = DateTime.Now.ToShortDateString();
            plan.PlanDate = DateTime.Now;
            Helpers.ReaderHelper.RefreshComboBox("select c.id, c.name from BillCategory c inner join Status s on c.statusid = s.id where s.name = 'Active'", ref cmbBillCategory, "BillCategory", "name", "id");
            Helpers.ReaderHelper.RefreshComboBox("select p.id, p.name from BillPurpose p inner join Status s on p.statusid = s.id where s.name = 'Active'", ref cmbBillPurpose, "BillPurpose", "name", "id");
            RefreshGrid();

        }
        #endregion

        #region Button Events
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            plan.Amount = txtAmount.SqlAmount;
            plan.Save(plan);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            plan.Delete(plan);
            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fPlanUpdate planU = new fPlanUpdate(this.plan, this);
            planU.MdiParent = this.MdiParent;
            planU.Show();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            Helpers.ReaderHelper.BindGrid(ref dataPlan, "spPlan", 1, "Plan");
            dataPlan.Columns[0].Width = 80;
            dataPlan.Columns[1].Width = 100;
            dataPlan.Columns[2].Width = 120;
        }

        private void ClearSurface()
        {
            txtAmount.Text = String.Empty;
            txtDescription.Text = String.Empty;
            //mtxtDate.Text = String.Empty;
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void mtxtPlanYear_TextChanged(object sender, EventArgs e)
        {
            plan.PlanYear = Convert.ToInt32(mtxtPlanYear.Text);
        }

        private void mtxtPlanMonth_TextChanged(object sender, EventArgs e)
        {
            plan.PlanMonth = Convert.ToInt32(mtxtPlanMonth.Text);
        }

        //private void txtAmount_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtAmount.Text.Length > 0)
        //        {
        //            plan.Amount = Classes.MainHelper.DecimalForSql(Convert.ToDecimal(txtAmount.Text));
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        //private void txtAmount_Leave(object sender, EventArgs e)
        //{
        //    TextBox txt = sender as TextBox;
        //    try
        //    {
        //        if (txt.Text.Length > 0)
        //        {
        //            txt.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(txt.Text));
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        private void cmbBillCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                plan.SetCategoryId(plan, ((DataRowView)cmbBillCategory.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void cmbBillPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                plan.SetPurposeId(plan, ((DataRowView)cmbBillPurpose.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            plan.Description = txtDescription.Text;
        }

        private void dataPlan_SelectionChanged(object sender, EventArgs e)
        {
            if (dataPlan.SelectedRows.Count > 0)
            {
                plan.Id = System.Convert.ToInt32(dataPlan.Rows[dataPlan.CurrentRow.Index].Cells[6].Value.ToString());
                plan = (Classes.Plan)(Helpers.ReaderHelper.SelectObjectOnId((object)plan, "spPlan", 11, plan.Id));
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
        #endregion

        private void amount1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
