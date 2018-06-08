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
    public partial class fIncome : Form
    {
        #region Fields
        private bool dataIsBuild = false;
        private Classes.Income income = null;
        #endregion

        #region Ctor
        public fIncome()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fIncome_Load(object sender, EventArgs e)
        {
            income = new Classes.Income();
            mtxtDate.Text = DateTime.Now.ToShortDateString();
            Helpers.ReaderHelper.RefreshComboBox("select c.id, c.name from IncomeCategory c inner join Status s on c.statusid = s.id where s.name = 'Active'", ref cmbIncomeCategory, "IncomeCategory", "name", "id");
            Helpers.ReaderHelper.RefreshComboBox("select p.id, p.name from IncomePaymen p inner join Status s on p.statusid = s.id where s.name = 'Active'", ref cmbIncomePaymen, "IncomePaymen", "name", "id");
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            income.Save(income);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            Helpers.ReaderHelper.BindGrid(ref dataIncome, "spIncome", 1, "Income");
            dataIncome.Columns[0].Width = 80;
            dataIncome.Columns[1].Width = 100;
            dataIncome.Columns[2].Width = 120;
        }

        private void ClearSurface()
        {
            txtAmount.Text = String.Empty;
            txtDescription.Text = String.Empty;
            mtxtDate.Text = String.Empty;
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length>0)
            {
                income.Amount = Classes.MainHelper.DecimalForSql(Convert.ToDecimal(txtAmount.Text));    
            }
        }

        private void mtxtDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                income.Date = System.Convert.ToDateTime(mtxtDate.Text);
            }
            catch
            {

            }
        }

        private void cmbIncomeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                income.SetCategoryId(income, ((DataRowView)cmbIncomeCategory.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void cmbIncomePaymen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                income.SetPaymenId(income, ((DataRowView)cmbIncomePaymen.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            income.Description = txtDescription.Text;
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
