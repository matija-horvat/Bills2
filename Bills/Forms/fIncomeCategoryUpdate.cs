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
    public partial class fIncomeCategoryUpdate : Form
    {
        #region Fields
        private Classes.IncomeCategory incC = null;
        private Forms.fIncomeCategory fincC = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public fIncomeCategoryUpdate()
        {
            InitializeComponent();
        }

        public fIncomeCategoryUpdate(Classes.IncomeCategory incCat)
        {
            this.incC = incCat;
            InitializeComponent();
        }

        public fIncomeCategoryUpdate(Classes.IncomeCategory incCat, Forms.fIncomeCategory fincCat)
        {
            this.incC = incCat;
            this.fincC = fincCat;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fIncomeCategoryUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = incC.Name;
            txtDescription.Text = incC.Description;

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            incC.Update(incC);
            fincC.UpdateHUD();
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
            incC.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            incC.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                incC.SetStatusId(incC, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
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
        #endregion
    }
}
