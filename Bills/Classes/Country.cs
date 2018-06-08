using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class Country: Classes.Base
    {
        private int _statusid;
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }

        #region Ctor
        public Country()
        {
           
        }

        public Country(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(Country country)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(country, "spCountry", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Country country)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spCountry", 4, country.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(Country country)
        {
            try
            {
                Helpers.NonQueryHelper.Update(country, "spCountry", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(Country country, string statusName)
        {
            country.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
    }
}
