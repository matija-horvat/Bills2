using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class BillPurpose: Classes.Base
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
        public BillPurpose()
        {
           
        }

        public BillPurpose(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(BillPurpose billPurp)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(billPurp, "spBillPurpose", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(BillPurpose billPurp)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spBillPurpose", 4, billPurp.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(BillPurpose billPurp)
        {
            try
            {
                Helpers.NonQueryHelper.Update(billPurp, "spBillPurpose", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(BillPurpose billPurp, string statusName)
        {
            billPurp.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
    }
}
