using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class Store: Classes.Base
    {
        #region Fields
        private string _adress = String.Empty;
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        private int _cityID;
        public int CityID
        {
            get { return _cityID; }
            set { _cityID = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _web;
        public string Web
        {
            get { return _web; }
            set { _web = value; }
        }

        private string _description = String.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _statusId;
        public int StatusID
        {
            get { return _statusId; }
            set { _statusId = value; }
        }
        #endregion

        #region Ctor
        public Store():base()
        {
            
        }

        public Store(string name, string adress, int cityID, string phone, string web, string desc, int statusid)
        {
            Name = name;
            Adress = adress;
            CityID = cityID;
            Phone = phone;
            Web = web;
            Description = desc;
            StatusID = statusid;
        }

        public void Save(Store store)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(store, "spStore", 2);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Store store)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spStore", 4, store.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(Store store)
        {
            try
            {
                Helpers.NonQueryHelper.Update(store, "spStore", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetCityId(Store store, string cityName)
        {
            store.CityID = Helpers.ReaderHelper.SelectId("select id from city where name = '" + cityName + "'");
        }

        public void SetStatusId(Store store, string statusName)
        {
            store.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
        #endregion

    }
}
