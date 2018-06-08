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
    public partial class Status : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        private Classes.Status status = null;
        #endregion

        #region Ctor
        public Status()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load
        private void Status_Load(object sender, EventArgs e)
        {
            status = new Classes.Status();
            conn = new SqlConnection(Form1.connString);
            adapter = new SqlDataAdapter("select name as [Status], BackColorGrid as [Boja grida], ForeColorGrid as [Boja fonta], id from Status", conn);

            List<string> colors = new List<string>();
            //get the color names from the Known color enum
            string[] colorNames = Enum.GetNames(typeof(KnownColor));

            cmbBackColorGrid.Items.AddRange(colorNames);
            cmbForeColorGrid.Items.AddRange(colorNames);
            
            RefreshGrid();

        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            status.Save(status);
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
            Helpers.ReaderHelper.RefreshGrid(ref dataStatus, adapter, "Status");
            dataStatus.Columns[0].Width = 300;
        }

        private List<string> GetColors()
        {
            //create a generic list of strings
            List<string> colors = new List<string>();
            //get the color names from the Known color enum
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            //iterate thru each string in the colorNames array
            foreach (string colorName in colorNames)
            {
                //cast the colorName into a KnownColor
                KnownColor knownColor = (KnownColor)Enum.Parse(typeof(KnownColor), colorName);
                //check if the knownColor variable is a System color
                if (knownColor > KnownColor.Transparent)
                {
                    //add it to our list
                    colors.Add(colorName);
                }
            }
            //return the color list
            return colors;
        }

        private void ClearSurface()
        {
            txtName.Text = String.Empty;
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            status.Name = txtName.Text;
        }

        private void cmbBackColorGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBCgrid.BackColor = Color.FromName(cmbBackColorGrid.SelectedItem.ToString());
            status.BackColorGrid = cmbBackColorGrid.SelectedItem.ToString();
        }

        private void cmbForeColorGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            picFCgrid.BackColor = Color.FromName(cmbForeColorGrid.SelectedItem.ToString());
            status.ForeColorGrid = cmbForeColorGrid.SelectedItem.ToString();
        }

        private void dataStatus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridViewRow row = dataStatus.Rows[e.RowIndex];
            try
            {
                if (row.Cells[1].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromName(row.Cells[1].Value.ToString());
                }
                if (row.Cells[2].Value.ToString() != "")
                {
                    row.DefaultCellStyle.ForeColor = Color.FromName(row.Cells[2].Value.ToString());
                }
            }
            catch 
            {
                
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
    }
}
