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
    public partial class Measure : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        private bool dataIsBuild = false;
        private Classes.Uom uom = null;
        #endregion

        #region Ctor
        public Measure()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load
        private void Measure_Load(object sender, EventArgs e)
        {
            uom = new Classes.Uom();
            conn = new SqlConnection(Form1.connString);
            adapter = new SqlDataAdapter("select name as [Jedinica mjere], id from UnitOfMeasure", conn);

            Helpers.ReaderHelper.RefreshComboBox("select id, name from Status", ref cmbStatus, "Status", "name", "id"); 
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            uom.Save(uom);
            RefreshGrid();
            ClearSurface();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fMeasureUpdate measure = new fMeasureUpdate(this.uom, this);
            measure.MdiParent = this.MdiParent;
            measure.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            uom.SetStatusId(uom, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            uom.SetStatusId(uom, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            uom.Name = txtName.Text;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                uom.SetStatusId(uom, ((DataRowView)cmbStatus.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void dataMeasure_SelectionChanged(object sender, EventArgs e)
        {
            if (dataMeasure.SelectedRows.Count > 0)
            {
                uom.Id = System.Convert.ToInt32(dataMeasure.Rows[dataMeasure.CurrentRow.Index].Cells[1].Value.ToString());
                uom = (Classes.Uom)(Helpers.ReaderHelper.SelectObjectOnId((object)uom, "spUom", 11, uom.Id));
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
            Helpers.ReaderHelper.RefreshGrid(ref dataMeasure, adapter, "UnitOfMeasure");
            dataMeasure.Columns[0].Width = 300;
        }

        private void ClearSurface()
        {
            txtName.Text = String.Empty;
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

    }
}
