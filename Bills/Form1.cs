using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Bills
{
    public partial class Form1 : Form
    {
        #region Fields
        public static string connString = String.Empty;
        public static string connStringPath = String.Empty;

        private bool m_bLayoutCalled = false;
        private System.Windows.Forms.Timer timer1;
        private DateTime m_dt;
        private MdiClient _mdiClient;
        public static string waterMark = String.Empty;
        public static DataTable tblServer = new DataTable();
        #endregion

        #region Ctor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                _mdiClient = c as MdiClient;
                if (_mdiClient != null)
                {
                    break;
                }
            }

            _mdiClient.Resize += new EventHandler(_mdiClient_Resize);
            ShowWaterMark();
            SetConnString();

            Forms.MDIBackground background = new Forms.MDIBackground();
            background.MdiParent = this;
            background.Show();
        }

        void _mdiClient_Resize(object sender, EventArgs e)
        {
            ShowWaterMark();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            if (m_bLayoutCalled == false)
            {
                m_bLayoutCalled = true;
                m_dt = DateTime.Now;
                if (Bills.SplashScreen.SplashForm != null)
                    Bills.SplashScreen.SplashForm.Owner = this;
                
                Bills.SplashScreen.CloseForm();
                this.Activate();
                timer1.Start();
            }
        }
        #endregion

        #region Menu Events
        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Country country = new Forms.Country();
            country.MdiParent = this;
            country.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Region region = new Forms.Region();
            region.MdiParent = this;
            region.Show();
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.City city = new Forms.City();
            city.MdiParent = this;
            city.Show();
        }

        private void kategorijeRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BillCategory billC = new Forms.BillCategory();
            billC.MdiParent = this;
            billC.Show();
        }

        private void trgovinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Store sto = new Forms.Store();
            sto.MdiParent = this;
            sto.Show();
        }

        private void namjeneRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BillPurpose billp = new Forms.BillPurpose();
            billp.MdiParent = this;
            billp.Show();
        }

        private void računiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Bill bill = new Forms.Bill();
            bill.MdiParent = this;
            bill.Show();
        }

        private void jedinicaMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Measure measure = new Forms.Measure();
            measure.MdiParent = this;
            measure.Show();
        }

        private void računToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.wBill wBill = new Forms.wBill();
            wBill.MdiParent = this;
            wBill.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Status status = new Forms.Status();
            status.MdiParent = this;
            status.Show();
        }

        private void konekcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.fConnection fconn = new Forms.fConnection(this);
            fconn.MdiParent = this;
            fconn.Show();

           lblconnection.Text = Form1.connString;
        }

        private void računiPoKategorijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.wBillMonthRecapitulation billRecap = new Forms.wBillMonthRecapitulation();
            billRecap.MdiParent = this;
            billRecap.Show();
        }

        private void prihoditoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vrstePrihodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.fIncomeCategory incomeCat = new Forms.fIncomeCategory();
            incomeCat.MdiParent = this;
            incomeCat.Show();
        }

        private void evidencijaPrihodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.fIncome income = new Forms.fIncome();
            income.MdiParent = this;
            income.Show();
        }

        private void uplatiteljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.fIncomePaymen incomePaymen = new Forms.fIncomePaymen();
            incomePaymen.MdiParent = this;
            incomePaymen.Show();
        }

        private void unosPlanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.fPlan plan = new Forms.fPlan();
            plan.MdiParent = this;
            plan.Show();
        }

        private void planStvarnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.wPlanRealCompare planReal = new Forms.wPlanRealCompare();
            planReal.MdiParent = this;
            planReal.Show();
        }
        #endregion

        #region Methods
        public void UpdateHUD()
        {
            this.lblconnection.Text = "Trenutna konekcija: ";
            this.lblconnection.Text += Form1.connString;
        }

        private void SetConnString()
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            connStringPath = appPath + "\\connString.txt";

            if (!File.Exists(connStringPath)) //file not exists
            {
                System.IO.FileStream fs = System.IO.File.Create(connStringPath);

                Forms.fConnection fconn = new Forms.fConnection(this);
                fconn.MdiParent = this;
                fconn.Show();
            }
            else //file exists
            {
                string[] lines = System.IO.File.ReadAllLines(connStringPath);

                if (lines.Count() < 1)
                {
                    Forms.fConnection fconn = new Forms.fConnection(this);
                    fconn.MdiParent = this;
                    fconn.Show();
                }
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    Form1.connString = String.Empty;
                    Form1.connString = line;
                }

                UpdateHUD();
            }

            
        }

        internal void ShowWaterMark()
        {
            Bitmap bufferImage;
            Rectangle r = new Rectangle(Point.Empty, _mdiClient.Size);

            if (r.Height <= 0 || r.Width <= 0)
            {
                return;
            }

            bufferImage = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(bufferImage);

            StringFormat sf = new StringFormat(StringFormatFlags.NoWrap);

            waterMark = "e-Troškovnik"+ "\n" +
                        "design by Matija Horvat";

            sf.LineAlignment = StringAlignment.Center;
            SolidBrush brush = new SolidBrush(Color.DimGray);
            g.FillRectangle(brush, r);
            brush.Dispose();

            Font font = null;
            try
            {
                font = new Font("Imprint MT Shadow", 45, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            catch 
            {
                font = new Font("Calibri", 45, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            
            sf.Alignment = StringAlignment.Center;
            sf.Trimming = StringTrimming.EllipsisWord;
            g.DrawString(waterMark, font, Brushes.DarkGray, (RectangleF)r, sf);

            font.Dispose();
            sf.Dispose();
            g.Dispose();

            _mdiClient.BackgroundImage = bufferImage;
            return;
        }
        #endregion

        #region UI Events
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(m_dt);
            //if( ts.TotalSeconds > 2 )
            //this.Close();
        }
        #endregion

        private void testResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
