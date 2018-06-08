using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class IncomePaymen : Classes.Base
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
        public IncomePaymen()
        {
           
        }

        public IncomePaymen(int id, string name)
            : base(id, name)
        {

        }
        #endregion

        public void Save(IncomePaymen incPay)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(incPay, "spIncomePaymen", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(IncomePaymen incPay)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spIncomePaymen", 4, incPay.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(IncomePaymen incPay)
        {
            try
            {
                Helpers.NonQueryHelper.Update(incPay, "spIncomePaymen", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(IncomePaymen incPay, string statusName)
        {
            incPay.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
            Update(incPay);
        }

    }
}
