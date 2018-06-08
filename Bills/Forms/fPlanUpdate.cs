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
    public partial class fPlanUpdate : Form
    {
        #region Fields
        private Classes.Plan plan = null;
        private Forms.fPlan fplan = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public fPlanUpdate()
        {
            InitializeComponent();
        }

        public fPlanUpdate(Classes.Plan plan)
        {
            this.plan = plan;
            InitializeComponent();
        }

        public fPlanUpdate(Classes.Plan plan, Forms.fPlan fplan)
        {
            this.plan = plan;
            this.fplan = fplan;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fPlanUpdate_Load(object sender, EventArgs e)
        {
            mtxtPlanYear.Text = plan.PlanYear.ToString();
            mtxtPlanMonth.Text = plan.PlanMonth.ToString();
            txtAmount.Text = plan.Amount;
            txtDescription.Text = plan.Description;
            mtxtDate.Text = plan.PlanDate.ToShortDateString();
            Helpers.ReaderHelper.RefreshComboBox("select c.id, c.name from BillCategory c inner join Status s on c.statusid = s.id where s.name = 'Active'", ref cmbBillCategory, "BillCategory", "name", "id");
            Helpers.ReaderHelper.RefreshComboBox("select p.id, p.name from BillPurpose p inner join Status s on p.statusid = s.id where s.name = 'Active'", ref cmbBillPurpose, "BillPurpose", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            plan.Update(plan);
            fplan.UpdateHUD();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text.Length > 0)
                {
                    plan.Amount = Classes.MainHelper.DecimalForSql(Convert.ToDecimal(txtAmount.Text));
                }
            }
            catch
            {

            }
        }

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
