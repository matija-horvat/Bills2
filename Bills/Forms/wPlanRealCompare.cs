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
    public partial class wPlanRealCompare : Form
    {
        #region Fields
        private Decimal sumPlan = 0;
        private Decimal sumReal = 0;
        private String sumValueString = String.Empty;
        #endregion

        #region Ctor
        public wPlanRealCompare()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void wPlanRealCompare_Load(object sender, EventArgs e)
        {
            mtxtBeginDate.Text = DateTime.Parse("1.1." + DateTime.Now.Year.ToString()).ToShortDateString();
            mtxtEndDate.Text = DateTime.Now.ToShortDateString();
            RefreshGrid();
        }
        #endregion

        #region Button Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {

            string[] paramNames = { "@datumod", "@datumdo" };
            object[] paramValues = { Convert.ToDateTime(mtxtBeginDate.Text), Convert.ToDateTime(mtxtEndDate.Text) };


            Helpers.ReaderHelper.BindGrid(ref dataPlan, "spPlanReal", 1,paramNames, paramValues, "Plan");
            Helpers.ReaderHelper.BindGrid(ref dataReal, "spPlanReal", 2, paramNames, paramValues, "BillBody");
            //Helpers.ReaderHelper.BindGrid(ref dataPlan, "spPlan", 1, "Plan");
            dataPlan.Columns[0].Width = 150;
            dataPlan.Columns[1].Width = 150;
            dataPlan.Columns[2].Width = 100;
            dataReal.Columns[0].Width = 150;
            dataReal.Columns[1].Width = 150;
            dataReal.Columns[2].Width = 100;
            sumPlan = 0;
            sumReal = 0;

            for (int i = 0; i < dataPlan.Rows.Count; i++)
            {
                sumValueString = dataPlan.Rows[i].Cells[2].Value.ToString();
                if (sumValueString.IndexOf(',', 0) > -1)
                {
                    sumValueString = sumValueString.Remove(sumValueString.IndexOf(',', 0),1);
                }
                
                sumPlan += Convert.ToDecimal(sumValueString.Replace('.', ','));
            }

            lblSumPlan.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(sumPlan.ToString()));


            for (int i = 0; i < dataReal.Rows.Count; i++)
            {
                sumValueString = dataReal.Rows[i].Cells[2].Value.ToString();
                if (sumValueString.IndexOf(',', 0) > -1)
                {
                    sumValueString = sumValueString.Remove(sumValueString.IndexOf(',', 0), 1);
                }
                sumReal += Convert.ToDecimal(sumValueString.Replace('.', ','));
            }


            lblSumReal.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal(sumReal.ToString()));

            lblDeference.Text = Classes.MainHelper.DecimalFormat(Convert.ToDecimal((sumPlan - sumReal).ToString()));

            if (sumPlan - sumReal < 0)
                lblDeference.ForeColor = Color.Red;
            else
                lblDeference.ForeColor = Color.Green;
        }

        #endregion

        #region UI Evetns
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, new RectangleF(2, 1, groupBox2.Size.Width - 3, groupBox2.Size.Height - 5));

            Brush linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
               new Rectangle(0, 0, groupBox2.Size.Width, groupBox2.Size.Height), Color.FromArgb(153, 182, 210), Color.FromArgb(204, 219, 240), 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(2, 1, groupBox2.Size.Width - 3, groupBox2.Size.Height - 5));

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
