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
    public partial class wBill : Form
    {
        #region Fields
        SqlConnection conn = null;
        private string sqlText = String.Empty;
        
        private Classes.BillHead head = null;
        private Classes.BillBody body = null;
        #endregion

        #region Ctor
        public wBill()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void wBill_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Form1.connString);
            //this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Button Events
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            Forms.Bill bill = new Forms.Bill();
            bill.MdiParent = this.MdiParent;
            bill.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Forms.BillBody body = new BillBody(this.head);
            body.MdiParent = this.MdiParent;
            body.Show();

            RefreshChildGrid();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Sigurno želite obrisati ovu stavku?", "Brisanje?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                Helpers.NonQueryHelper.DeleteOnId("spBillInsert", 4, body.Id);

                head.TotalSum = System.Convert.ToDecimal(Classes.MainHelper.GetOneValue("select coalesce((sum(sum)),0) from billbody where billhead = " + head.Id.ToString()));
                head.TotalPdv = System.Convert.ToDecimal(Classes.MainHelper.GetOneValue("select coalesce((sum(sum)),0) from billbody where billhead = " + head.Id.ToString()));

                Helpers.NonQueryHelper.Update(head, "spBillInsert", 2);

                RefreshGrid();
                RefreshChildGrid();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            Forms.BillBodyUpdate body = new BillBodyUpdate(this.head, this.body);
            body.MdiParent = this.MdiParent;
            body.Show();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            if (dataHead.DataSource != null)
                dataHead.DataSource = null;
            else
                dataHead.Rows.Clear();
            
            try
            {
                Helpers.ReaderHelper.BindBillHeadOnNode("spBillQuery", 1, treeView1.SelectedNode.Name, ref dataHead, "BillHead");
                
                dataHead.AutoSize = false;
                dataHead.Columns[0].Width = 150;
                dataHead.Columns[2].Width = 200;
                dataHead.Columns[3].Width = 200;
                dataHead.Columns[4].Width = 200;
                dataHead.Columns[7].Width = 200;

                dataHead.Columns[8].Visible = false;
                dataHead.Columns[9].Visible = false;
                dataHead.Columns[10].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// Popunjavanje grida sa stavkama računa.
        /// </summary>
        private void RefreshChildGrid()
        {
            if (dataBody.DataSource != null)
                dataBody.DataSource = null;
            else
                dataBody.Rows.Clear();
            
            try
            {
                if (dataHead.SelectedRows.Count > 0)
                {
                    Helpers.ReaderHelper.BindBillBodyOnId("spBillQuery", 2, System.Convert.ToInt32(dataHead.Rows[dataHead.CurrentRow.Index].Cells[8].Value.ToString()), ref dataBody, "BillBody");
                }

                dataBody.Columns[1].Visible = false;
                dataBody.Columns[7].Visible = false;
                dataBody.Columns[8].Visible = false;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region UI Events
        private void dataHead_SelectionChanged(object sender, EventArgs e)
        {
            if (dataHead.SelectedRows.Count > 0)
            {
                RefreshChildGrid();
                

                head = Helpers.ReaderHelper.SelectHeadOnId("spBillQuery", 3, System.Convert.ToInt32(dataHead.Rows[dataHead.CurrentRow.Index].Cells[8].Value.ToString()));
            }
        }

        private void dataBody_SelectionChanged(object sender, EventArgs e)
        {
            if (dataBody.SelectedRows.Count > 0)
            {
                body = Helpers.ReaderHelper.SelectBodyOnId("spBillQuery", 22, System.Convert.ToInt32(dataBody.Rows[dataBody.CurrentRow.Index].Cells[7].Value.ToString()));
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string node = treeView1.SelectedNode.Name;

            RefreshGrid();
        }

        private void dataHead_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataHead.Rows[e.RowIndex];
            try
            {
                if (row.Cells[1].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromName(row.Cells[10].Value.ToString());
                }
                if (row.Cells[2].Value.ToString() != "")
                {
                    row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells[9].Value.ToString());
                }
            }
            catch
            {

            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox1.Size.Width - 3, groupBox1.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, groupBox1.Size.Width, groupBox1.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox1.Size.Width - 3, groupBox1.Size.Height - 5));

            linearGradientBrush.Dispose();
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
