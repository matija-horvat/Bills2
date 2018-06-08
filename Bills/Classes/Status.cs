using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Bills.Classes
{
    public class Status: Classes.Base
    {
        #region Fields
        private string _foreColorGrid = String.Empty;
        public string ForeColorGrid
        {
            get { return _foreColorGrid; }
            set { _foreColorGrid = value; }
        }

        private string _backColorGrid = String.Empty;
        public string BackColorGrid
        {
            get { return _backColorGrid; }
            set { _backColorGrid = value; }
        }
        #endregion

        #region Ctor
        public Status()
        {
           
        }

        public Status(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(Status status)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(status, "spStatus", 2);
            }   
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Status status)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spStatus", 4, status.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
