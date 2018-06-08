using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class City: Classes.Base
    {
        #region Fields
        private string _ponumber = String.Empty;
        public string PoNumber
        {
            get { return _ponumber; }
            set { _ponumber = value; }
        }

        private int _regionid;
        public int RegionId
        {
            get { return _regionid; }
            set { _regionid = value; }
        }

        private int _statusid;
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }
        #endregion

        #region Ctor
        public City()
        {
           
        }

        public City(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(City city)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(city, "spCity", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(City city)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spCity", 4, city.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(City city)
        {
            try
            {
                Helpers.NonQueryHelper.Update(city, "spCity", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetRegionId(City city, string regionName)
        {
            city.RegionId = Helpers.ReaderHelper.SelectId("select id from region where name = '" + regionName + "'");
        }

        public void SetStatusId(City city, string statusName)
        {
            city.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
    }
}
