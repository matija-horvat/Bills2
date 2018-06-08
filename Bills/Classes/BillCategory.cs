using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class BillCategory: Classes.Base
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
        public BillCategory()
        {
           
        }

        public BillCategory(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(BillCategory billCat)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(billCat, "spBillCategory", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(BillCategory billCat)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spBillCategory", 4, billCat.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(BillCategory billCat)
        {
            try
            {
                Helpers.NonQueryHelper.Update(billCat, "spBillCategory", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(BillCategory billCat, string statusName)
        {
            billCat.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
    }
}
