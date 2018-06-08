using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class Region: Classes.Base
    {
        #region Fields
        private int _countryid;
        public int CountryId
        {
            get { return _countryid; }
            set { _countryid = value; }
        }

        private int _statusid;
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }
        #endregion

        #region Ctor
        public Region()
        {
           
        }

        public Region(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(Region region)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(region, "spRegion", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Region region)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spRegion", 4, region.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(Region region)
        {
            try
            {
                Helpers.NonQueryHelper.Update(region, "spRegion", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetCountryId(Region region, string countryName)
        {
            region.CountryId = Helpers.ReaderHelper.SelectId("select id from Country where name = '" + countryName + "'");
        }

        public void SetStatusId(Region region, string statusName)
        {
            region.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
    }
}
