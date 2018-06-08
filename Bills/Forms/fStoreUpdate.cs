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
    public partial class fStoreUpdate : Form
    {
        #region Fields
        private Classes.Store store = null;
        private Forms.Store fStore = null;
        private bool dataIsBuild = false;
        #endregion

        #region Ctor
        public fStoreUpdate()
        {
            InitializeComponent();
        }

        public fStoreUpdate(Classes.Store storeU)
        {
            this.store = storeU;
            InitializeComponent();
        }

        public fStoreUpdate(Classes.Store storeU, Forms.Store fStore)
        {
            this.store = storeU;
            this.fStore = fStore;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void fStoreUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = store.Name;
            txtAdress.Text = store.Adress;
            txtDescription.Text = store.Description;
            txtWeb.Text = store.Web;
            mtxtTelefon.Text = store.Phone;

            Helpers.ReaderHelper.RefreshComboBox("select id, name from City", ref cmbCity, "City", "name", "id");
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            store.Update(store);
            fStore.UpdateHUD();
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
