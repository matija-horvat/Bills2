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
    public partial class fIncomePaymenUpdate : Form
    {
        #region Fields
        private Classes.IncomePaymen incP = null;
        private Forms.fIncomePaymen fincP = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public fIncomePaymenUpdate()
        {
            InitializeComponent();
        }

        public fIncomePaymenUpdate(Classes.IncomePaymen incPay)
        {
            this.incP = incPay;
            InitializeComponent();
        }

        public fIncomePaymenUpdate(Classes.IncomePaymen incPay, Forms.fIncomePaymen fincPay)
        {
            this.incP = incPay;
            this.fincP = fincPay;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fIncomePaymenUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = incP.Name;
            txtDescription.Text = incP.Description;

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            incP.Update(incP);
            fincP.UpdateHUD();
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
            incP.Name = txtName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            incP.Description = txtDescription.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                incP.SetStatusId(incP, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
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
