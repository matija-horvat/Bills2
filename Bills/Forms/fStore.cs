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
    public partial class Store : Form
    {
        #region Fields
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        
        private bool dataIsBuild = false;
        private Classes.Store store = null;
        #endregion

        #region Ctor
        public Store()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void Store_Load(object sender, EventArgs e)
        {
            store = new Classes.Store();
            conn = new SqlConnection(Form1.connString);
            adapter = new SqlDataAdapter("select s.name as [Naziv trgovine], s.Adress as Adresa, c.name as [Grad], s.PhoneNumber as Telefon, s.Web, s.description as [Napomena], s.id from store s left join city c on c.Id = s.cityid where statusid = 1", conn);

            Helpers.ReaderHelper.RefreshComboBox("select id, name from City", ref cmbCity, "City", "name", "id"); 
            RefreshGrid();
            
        }
        #endregion

        #region Button events
        private void btnSave_Click(object sender, EventArgs e)
        {
            store.StatusID = 1;
            store.Save(store);

            RefreshGrid();
            ClearSurface();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            store.Id = (int)dataStore.Rows[dataStore.CurrentRow.Index].Cells[6].Value;
            //store.Delete(dataStore.Rows[dataStore.CurrentRow.Index].Cells[6].Value.ToString());
            store.Delete(store);
            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.fStoreUpdate storeU = new fStoreUpdate(this.store, this);
            storeU.MdiParent = this.MdiParent;
            storeU.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            store.SetStatusId(store, "Active");
            RefreshGrid();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            store.SetStatusId(store, "Inactive");
            RefreshGrid();
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            Helpers.ReaderHelper.RefreshGrid(ref dataStore, adapter, "Store");
            dataStore.Columns[0].Width = 300;
            dataStore.Columns[1].Width = 200;
            dataStore.Columns[2].Width = 150;
            dataStore.Columns[3].Width = 150;
            dataStore.Columns[4].Width = 250;
            dataStore.Columns[5].Width = 250;
        }

        private void ClearSurface()
        {
            txtName.Text = String.Empty;
            txtAdress.Text = String.Empty;
            mtxtTelefon.Text = String.Empty;
            txtWeb.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtName.Focus();
        }

        public void UpdateHUD()
        {
            RefreshGrid();
        }
        #endregion

        #region UI Events
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            store.Name = txtName.Text;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataIsBuild)
            {
                store.SetCityId(store, ((DataRowView)cmbCity.SelectedItem).Row["name"].ToString());
            }

            dataIsBuild = true;
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            store.Adress = txtAdress.Text;
        }

        private void mtxtTelefon_TextChanged(object sender, EventArgs e)
        {
            store.Phone = mtxtTelefon.Text;
        }

        private void txtWeb_TextChanged(object sender, EventArgs e)
        {
            store.Web = txtWeb.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            store.Description = txtDescription.Text;
        }

        private void dataStore_SelectionChanged(object sender, EventArgs e)
        {
            if (dataStore.SelectedRows.Count > 0)
            {
                store.Id = System.Convert.ToInt32(dataStore.Rows[dataStore.CurrentRow.Index].Cells[6].Value.ToString());
                store = (Classes.Store)(Helpers.ReaderHelper.SelectObjectOnId((object)store, "spStore", 11, store.Id));
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

    }
}
