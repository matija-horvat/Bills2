using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Bills.Forms
{
    public partial class fCreateDataBase : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlCommand cmd3 = null;

        private string scriptCreatebasePath = String.Empty;
        private string scriptCreatebase = String.Empty;
        private string scriptCreateTablePath = String.Empty;
        private string scriptCreateTable = String.Empty;
        private string scriptProcedure = String.Empty;
        private string[] storeProceduresPath;
        private string _server = String.Empty;
        private string directory = String.Empty;
        
        FileInfo file = null;
        #endregion

        #region Ctor
        public fCreateDataBase()
        {
            InitializeComponent();
        }

        public fCreateDataBase(string server)
        {
            this._server = server;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fCreateDataBase_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Button Events
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string sqlConnectionString = @"Server=" + _server + ";database=master;Integrated Security=True";
            conn = new SqlConnection(sqlConnectionString);

            SqlCommand cmd = new SqlCommand(scriptCreatebase);
            SqlCommand cmd2 = new SqlCommand(scriptCreateTable);
            cmd.Connection = conn;
            cmd2.Connection = conn;

            try
            {
                if (conn.State==ConnectionState.Open)
                    conn.Close();
                
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();

                sqlConnectionString = @"Server=" + _server + ";database=Bills;Integrated Security=True";
                conn = new SqlConnection(sqlConnectionString);
                CreateAllProcedures();
            }
            catch (Exception ex)
            {
                conn.Close();
                file.OpenText().Close();
                MessageBox.Show(ex.ToString());
                return;
            }

            file.OpenText().Close();
            MessageBox.Show("Baza je uspješno dodana!");
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directory = folderBrowserDialog1.SelectedPath;
                GetAllFiles();
            }

        }
        #endregion

        #region Methods
        private void GetAllFiles()
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(directory);

            int i = 0;

            foreach (string filePath in fileEntries)
            {
                if (filePath.IndexOf("BillCreateTable") != -1)
                {
                    file = new FileInfo(filePath);
                    scriptCreateTable = file.OpenText().ReadToEnd();
                    txtScriptTablePath.Text = filePath;
                    file.OpenText().Close();
                }

                if (filePath.IndexOf("BillsCreateBase") != -1)
                {
                    file = new FileInfo(filePath);
                    scriptCreatebase = file.OpenText().ReadToEnd();
                    txtScriptPath.Text = filePath;
                    file.OpenText().Close();
                }

                if (filePath.IndexOf(".prc") != -1)
                {
                    i++;
                }
            }

            storeProceduresPath = new string[i];
            i = 0;

            foreach (string filePath in fileEntries)
            {
                if (filePath.IndexOf(".prc") != -1)
                {
                    storeProceduresPath[i++] = filePath;
                    txtSearchProcedure.Text += filePath + "\r\n";
                }
            }
        }

        private void CreateAllProcedures()
        {
            foreach (string fileScript in storeProceduresPath)
            {
                file = new FileInfo(fileScript);
                scriptProcedure = file.OpenText().ReadToEnd();

                cmd3 = new SqlCommand(scriptProcedure);
                cmd3.Connection = conn;

                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    conn.Open();
                    cmd3.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    file.OpenText().Close();
                    MessageBox.Show(ex.ToString());
                    return;
                }
                finally
                {
                    file.OpenText().Close();
                }
            }

        }
        #endregion

        #region UI Events
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
