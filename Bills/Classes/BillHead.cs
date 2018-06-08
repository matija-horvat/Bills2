using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class BillHead
    {
        #region Fields
        SqlConnection conn = null;
        SqlCommand comm = null;
        private string sqlText = String.Empty;

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _billNumber = String.Empty;
        public string BillNumber 
        {
            get { return _billNumber; }
            set { _billNumber = value;} 
        }

        private DateTime _billDate = DateTime.Now;
        public DateTime BillDate
        {
            get { return _billDate; }
            set { _billDate = value; }
        }

        private int _storeID;
        public int StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }

        private int _billCategoryID;
        public int BillCategoryID
        {
            get { return _billCategoryID; }
            set { _billCategoryID = value; }
        }

        private int _billPurposeID;
        public int BillPurposeID
        {
            get { return _billPurposeID; }
            set { _billPurposeID = value; }
        }

        private string _description = String.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private Decimal? _totalSum;
        public Decimal? TotalSum
        {
            get { return _totalSum; }
            set { _totalSum = value; }
        }

        private Decimal? _totalPdv;
        public Decimal? TotalPdv
        {
            get { return _totalPdv; }
            set { _totalPdv = value; }
        }

        private int _statusid;
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }
        #endregion

        #region Ctor
        public BillHead()
        {
            conn = new SqlConnection(Form1.connString);
        }

        public BillHead(string number, DateTime date, int storeID, int categoryID, int purposeID, string desc, int statusid)
        {
            conn = new SqlConnection(Form1.connString);
            BillNumber = number;
            BillDate = date;
            StoreID = storeID;
            BillCategoryID = categoryID;
            BillPurposeID = purposeID;
            Description = desc;
            StatusID = statusid;
        }

        #endregion

        public void Save(BillHead head)
        {

            Helpers.NonQueryHelper.Insert(head, "spBillInsert", 1);
           
            try
            {
               SetId();//get max id from billhead
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetId()
        {
            comm = new SqlCommand("select max(id) from billhead ", conn);

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                this.Id = (int)comm.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetStatusId(BillHead head, string statusName)
        {
            head.StatusID = Helpers.ReaderHelper.SelectId("select id from status where name = '" + statusName + "'");
        }

        public void SetStoreId(BillHead head, string storeName)
        {
            head.StoreID = Helpers.ReaderHelper.SelectId("select id from store where name = '" + storeName + "'");
        }

        public void SetCategoryId(BillHead head, string categoryName)
        {
            head.BillCategoryID = Helpers.ReaderHelper.SelectId("select id from billcategory where name = '" + categoryName + "'");
        }

        public void SetPurposeId(BillHead head, string purposeName)
        {
            head.BillPurposeID = Helpers.ReaderHelper.SelectId("select id from billpurpose where name = '" + purposeName + "'");
        }

    }
}
