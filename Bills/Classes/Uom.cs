using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class Uom: Classes.Base
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
        public Uom()
        {
           
        }

        public Uom(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(Uom uom)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(uom, "spUom", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Uom uom)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spUom", 4,  uom.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(Uom uom)
        {
            try
            {
                Helpers.NonQueryHelper.Update(uom, "spUom", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(Uom uom, string statusName)
        {
            uom.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }
    }
}
