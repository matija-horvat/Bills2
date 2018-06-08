using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Data.Sql;
using System.IO;

namespace Bills.Forms
{
    public partial class fConnection : Form
    {
        #region Fields
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string server = String.Empty;
        private string database = String.Empty;
        private string databaseLdf = String.Empty;
        private string basePath = String.Empty;
        private Form1 parent = null;
        #endregion

        #region Ctor
        public fConnection()
        {
            InitializeComponent();
        }

        public fConnection(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fConnection_Load(object sender, EventArgs e)
        {
            lblConnString.Text = "Server=" + server + ";Initial Catalog=" + database + ";Integrated Security=True";
            BindServers();
        }
        #endregion

        #region Button Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowse.Text = openFileDialog1.FileName;
                //database = Path.GetFileName(txtBrowse.Text);
                database = txtBrowse.Text;
                databaseLdf = txtBrowse.Text.Replace("Bills.mdf", "Bills_log.ldf");
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (server == String.Empty)
            {
                MessageBox.Show("Niste odabrali server");
                return;
            }

            if (database == String.Empty)
            {
                MessageBox.Show("Niste odredili putanju!");
                return;
            }

            conn = new SqlConnection("Server=" + server + "; Data Source=;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "EXEC sp_attach_db @dbname = N'Bills', " +
                               "@filename1 = N'" + database + "', " +
                               "@filename2 = N'" + databaseLdf + "'";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cmd.Dispose();
            conn.Dispose();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (server == String.Empty)
            {
                MessageBox.Show("Niste odabrali server!");
                return;
            }
            fCreateDataBase createBase = new fCreateDataBase(server);
            createBase.MdiParent = this.MdiParent;
            createBase.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                txtConnStatus.Text = "Konekcija uspješna!";
            }
            catch (Exception ex)
            {
                txtConnStatus.Text = "Konekcija nije uspjela!";
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (server == String.Empty)
            {
                MessageBox.Show("Niste odabrali server!");
                return;
            }
            if (database == String.Empty)
            {
                MessageBox.Show("Niste odabrali bazu!");
                return;
            }

            TextWriter tw = new StreamWriter(Form1.connStringPath);

            // write a line of text to the file
            tw.WriteLine(lblConnString.Text);
            Form1.connString = String.Empty;
            Form1.connString = lblConnString.Text;
            this.parent.UpdateHUD();

            // close the stream
            tw.Close();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
            this.Close();
        }
        #endregion

        #region UI Events
        private void cmbBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            database = cmbBaseName.SelectedItem.ToString();
            lblConnString.Text = "Server=" + server + ";Initial Catalog=" + database + ";Integrated Security=True";
        }

        private void cmbBaseName_DropDown(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=" + cmbServerName.SelectedItem.ToString() + ";Integrated Security=True");

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_databases";

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }

            cmbBaseName.Items.Clear();
            while (reader.Read())
            {
                cmbBaseName.Items.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();
        }

        private void cmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            server = cmbServerName.SelectedItem.ToString();
            lblConnString.Text = "Server=" + server + ";Initial Catalog=" + database + ";Integrated Security=True";
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
        private void BindServers()
        {
            loaderServer.Visible = true;
            cmbServerName.Items.Clear();

            for (int i = 0; i < Bills.Form1.tblServer.Rows.Count; i++)
            {
                cmbServerName.Items.Add(Bills.Form1.tblServer.Rows[i].ItemArray.First());
            }

            loaderServer.Visible = false;
        }
        #endregion

    }
}
