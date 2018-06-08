using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bills.Forms
{
    public partial class wBillMonthRecapitulation : Form
    {
        #region Fields
        DataTable tblDiagram = new DataTable();
        private Nullable<int> year = null;
        private Nullable<int> month = null;
        private Nullable<int> day = null;
        private int daniUmjesecu;
        #endregion

        #region Ctor
        public wBillMonthRecapitulation()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void wBillMonthRecapitulation_Load(object sender, EventArgs e)
        {
            PopulateCmbYear();
            cmbMonth.SelectedIndex = 0;
        }
        #endregion

        #region Button Events
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Helpers.ReaderHelper.BindGrid(ref dataBillMonthRecap, "spBillQuery", 4, Convert.ToInt32(cmbYear.SelectedItem.ToString()), "BillBody");
            dataBillMonthRecap.Columns[2].Width = 150;

            //DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.Font = new Font(new FontFamily("Arial"),7, FontStyle.Bold);
            dataBillMonthRecap.Columns[2].DefaultCellStyle.Font = new Font(new FontFamily("Times new roman"), 7, FontStyle.Italic);
            dataBillMonthRecap.Columns[3].DefaultCellStyle.Font = new Font(new FontFamily("Courier new"), 8, FontStyle.Bold);

            FillDiagramRecap();

            if (cmbMonth.Text != "NULL")
            {
                FillDiagramRecapMonth();
            }

            if (cmbDay.Text != "NULL")
            {
                FillDiagramRecapDay();
            }
        }
        #endregion

        #region UI Events
        private void cmbDijagramTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartRekap.Series["Iznos u kn"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cmbDijagramTip.Text, true);
            chartRekapMonth.Series["Iznos u kn"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cmbDijagramTip.Text, true);
            chartRekapDay.Series["Iznos u kn"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cmbDijagramTip.Text, true);

            FillDiagramRecap();

            if (cmbMonth.Text != "NULL")
            {
                FillDiagramRecapMonth();
            }

            if (cmbDay.Text != "NULL")
            {
                FillDiagramRecapDay();
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex > -1)
            {
                switch (cmbMonth.SelectedItem.ToString())
                {
                    case "Siječanj":
                        month = 1;
                        daniUmjesecu = 31;
                        break;
                    case "Veljača":
                        month = 2;
                        daniUmjesecu = 28;
                        break;
                    case "Ožujak":
                        month = 3;
                        daniUmjesecu = 31;
                        break;
                    case "Travanj":
                        month = 4;
                        daniUmjesecu = 30;
                        break;
                    case "Svibanj":
                        month = 5;
                        daniUmjesecu = 31;
                        break;
                    case "Lipanj":
                        month = 6;
                        daniUmjesecu = 30;
                        break;
                    case "Srpanj":
                        month = 7;
                        daniUmjesecu = 31;
                        break;
                    case "Kolovoz":
                        month = 8;
                        daniUmjesecu = 31;
                        break;
                    case "Rujan":
                        month = 9;
                        daniUmjesecu = 30;
                        break;
                    case "Listopad":
                        month = 10;
                        daniUmjesecu = 31;
                        break;
                    case "Studeni":
                        month = 11;
                        daniUmjesecu = 30;
                        break;
                    case "Prosinac":
                        month = 12;
                        daniUmjesecu = 31;
                        break;
                    default:
                        break;
                }

                cmbDay.Items.Clear();
                cmbDay.Items.Add("NULL");
                for (int i = 1; i <= daniUmjesecu; i++)
                {
                    cmbDay.Items.Add(i);
                }

                cmbDay.SelectedIndex = 0;
            }
        }

        private void cbtn3d_CheckedChanged(object sender, EventArgs e)
        {
            //chartRekap.Series["I"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cmbDijagramTip.Text, true);
            //chartRekapMonth.Series["I"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cmbDijagramTip.Text, true);
            //chartRekapDay.Series["I"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cmbDijagramTip.Text, true);

            FillDiagramRecap();

            if (cmbMonth.Text != "NULL")
            {
                FillDiagramRecapMonth();
            }

            if (cmbDay.Text != "NULL")
            {
                FillDiagramRecapDay();
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex > -1)
            {
                year = Convert.ToInt32(cmbYear.Text);
            }

        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDay.SelectedIndex > -1 && cmbDay.Text != "NULL")
            {
                day = Convert.ToInt32(cmbDay.Text);
            }
        }
        #endregion

        #region Methods
        private void PopulateCmbYear()
        {
            cmbYear.Items.Clear();

            for (int i = 10; i >= 0; i--)
            {
                cmbYear.Items.Add(DateTime.Now.Year - i);
            }

            cmbYear.SelectedIndex = 10;
        }

        private void FillDiagramRecap()
        {
            chartRekap.Series["Iznos u kn"]["DrawingStyle"] = "Emboss";
            chartRekap.Series["Iznos u kn"].Color = Color.DarkSlateGray;
            chartRekap.Series["Iznos u kn"].ShadowColor = Color.Blue;
            chartRekap.Series["Iznos u kn"].IsValueShownAsLabel = true;

            try
            {
                chartRekap.Series["Iznos u kn"].XValueMember = "Mjesec";
                chartRekap.Series["Iznos u kn"].YValueMembers = "Iznos(kn)";

                chartRekap.Titles.Clear();
                Title title1 = new Title();
                title1.Text = "Rekapitulacije računa po mjesecima za " + cmbYear.SelectedItem.ToString() + " godinu";
                chartRekap.Titles.Add(title1);
                //Title title2 = new Title();
                //title2.Text = cmbYear.SelectedItem.ToString() + " godinu";
                //chartRekap.Titles.Add(title2);

                chartRekap.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = cbtn3d.Checked;

                tblDiagram = Helpers.ReaderHelper.GetDataTable("spBillQuery", 5, year, month, day);
                chartRekap.DataSource = tblDiagram;
                chartRekap.DataBind();
                chartRekap.Visible = true;
                

            }
            catch (Exception ex)
            {
                //System.ArgumentException: 
                if (ex.Message.ToString() == "Column with name 'Mjesec' was not found.")
                {
                    FillDiagramRecap();
                    return;
                }
                if (ex.Message.ToString() == "Column with name 'Iznos(kn)' was not found.")
                {
                    FillDiagramRecap();
                    return;
                }

                MessageBox.Show("Greška kod prikaza dijagrama.");
                return;
            }


        }

        private void FillDiagramRecapMonth()
        {
            tblDiagram = new DataTable();

            chartRekapMonth.Series["Iznos u kn"]["DrawingStyle"] = "Emboss";
            chartRekapMonth.Series["Iznos u kn"].Color = Color.DarkSlateGray;
            chartRekapMonth.Series["Iznos u kn"].ShadowColor = Color.Blue;
            chartRekapMonth.Series["Iznos u kn"].IsValueShownAsLabel = true;

            try
            {
                chartRekapMonth.Series["Iznos u kn"].XValueMember = "Kategorija";
                chartRekapMonth.Series["Iznos u kn"].YValueMembers = "Iznos(kn)";

                chartRekapMonth.Titles.Clear();
                Title title1 = new Title();
                title1.Text = "Rekapitulacije računa po vrsti troška za mjesec " + cmbMonth.Text + " godinu " + cmbYear.SelectedItem.ToString();
                chartRekapMonth.Titles.Add(title1);
                //Title title2 = new Title();
                //title2.Text = "za mjesec " + cmbMonth.Text + " godinu " + cmbYear.SelectedItem.ToString();
                //chartRekapMonth.Titles.Add(title2);

                chartRekapMonth.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = cbtn3d.Checked;

                tblDiagram = Helpers.ReaderHelper.GetDataTable("spBillQuery", 6, year, month, day);
                chartRekapMonth.DataSource = tblDiagram;
                chartRekapMonth.DataBind();
                chartRekapMonth.Visible = true;

            }
            catch (Exception ex)
            {
                //System.ArgumentException: 
                if (ex.Message.ToString() == "Column with name 'Kategorija' was not found.")
                {
                    FillDiagramRecapMonth();
                    return;
                }
                if (ex.Message.ToString() == "Column with name 'Iznos(kn)' was not found.")
                {
                    FillDiagramRecapMonth();
                    return;
                }

                MessageBox.Show("Greška kod prikaza dijagrama.");
                return;
            }


        }

        private void FillDiagramRecapDay()
        {
            chartRekapDay.Series["Iznos u kn"]["DrawingStyle"] = "Emboss";
            chartRekapDay.Series["Iznos u kn"].Color = Color.DarkSlateGray;
            chartRekapDay.Series["Iznos u kn"].ShadowColor = Color.Blue;
            chartRekapDay.Series["Iznos u kn"].IsValueShownAsLabel = true;

            try
            {
                chartRekapDay.Series["Iznos u kn"].XValueMember = "Kategorija";
                chartRekapDay.Series["Iznos u kn"].YValueMembers = "Iznos(kn)";

                chartRekapDay.Titles.Clear();
                Title title1 = new Title();
                title1.Text = "Rekapitulacije računa po vrsti troška za "+ cmbDay.Text + "." + month.ToString() + "." + cmbYear.SelectedItem.ToString() + " godinu";
                chartRekapDay.Titles.Add(title1);
                //Title title2 = new Title();
                //title2.Text = cmbDay.Text + "." + month.ToString() + "." + cmbYear.SelectedItem.ToString() + " godinu";
                //chartRekapDay.Titles.Add(title2);

                chartRekapDay.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = cbtn3d.Checked;

                tblDiagram = Helpers.ReaderHelper.GetDataTable("spBillQuery", 7, year, month, day );
                chartRekapDay.DataSource = tblDiagram;
                chartRekapDay.DataBind();
                chartRekapDay.Visible = true;
            }
            catch (Exception ex)
            {
                //System.ArgumentException: 
                if (ex.Message.ToString() == "Column with name 'Kategorija' was not found.")
                {
                    FillDiagramRecapDay();
                    return;
                }
                if (ex.Message.ToString() == "Column with name 'Iznos(kn)' was not found.")
                {
                    FillDiagramRecapDay();
                    return;
                }

                MessageBox.Show("Greška kod prikaza dijagrama.");
                return;
            }


        }
        #endregion
    }
}
