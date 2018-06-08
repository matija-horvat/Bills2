using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class IncomeCategory : Classes.Base
    {
        #region Fields
        private string _description = String.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _statusid;
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }
        #endregion

        #region Ctor
        public IncomeCategory()
        {
           
        }

        public IncomeCategory(int id, string name)
            : base(id, name)
        {

        }
        #endregion

        public void Save(IncomeCategory incCat)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(incCat, "spIncomeCategory", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(IncomeCategory incCat)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spIncomeCategory", 4, incCat.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(IncomeCategory incCat)
        {
            try
            {
                Helpers.NonQueryHelper.Update(incCat, "spIncomeCategory", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(IncomeCategory incCat, string statusName)
        {
            incCat.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
            Update(incCat);
        }
    }
}
