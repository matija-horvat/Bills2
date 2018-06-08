using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class BillBody
    {
        #region Fields
        SqlConnection conn = null;
        private string sqlText = String.Empty;

        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _headId;
        public int HeadId
        {
            get { return _headId; }
            set { _headId = value; }
        }

        private string _articl = String.Empty;
        public string Articl 
        {
            get { return _articl; }
            set { _articl = value; } 
        }

        private Decimal _quantity ;
        public Decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private int _uomID;
        public int UomID
        {
            get { return _uomID; }
            set { _uomID = value; }
        }

        private Decimal _sum;
        public Decimal Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        private Decimal _pdv;
        public Decimal Pdv
        {
            get { return _pdv; }
            set { _pdv = value; }
        }

        private string _description = String.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion

        #region Ctor
        public BillBody()
        {
            conn = new SqlConnection(Form1.connString);
        }

        public BillBody(int headId, string articl, Decimal quantity, Decimal sum, Decimal pdv, int uomID, string desc)
        {
            conn = new SqlConnection(Form1.connString);
            HeadId = headId;
            Articl = articl;
            Quantity = quantity;
            Sum = sum;
            Pdv = pdv;
            UomID = uomID;
            Description = desc;
        }

        #endregion

        public void Save(BillBody body)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(body, "spBillInsert", 5);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            //sqlText = "Insert into BillBody (billhead, articlname, quantity, unitofmeasureid, sum, pdv, description) values ( " + body.HeadId + ", '" + body.Articl + "', " + body.Quantity + ", " + body.UomID.ToString() + ", '" + Classes.MainHelper.DecimalForSql(body.Sum) + "', '" + Classes.MainHelper.DecimalForSql(body.Pdv) + "', '" + body.Description + "' )";
            //comm = new SqlCommand(sqlText, conn);

            //try
            //{
            //    if (conn.State == ConnectionState.Open)
            //        conn.Close();

            //    conn.Open();
            //    comm.ExecuteNonQuery();
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    conn.Close();
            //    MessageBox.Show(ex.ToString());
            //}
        }

        public void SetUomId(BillBody body, string uomName)
        {
            body.UomID = Helpers.ReaderHelper.SelectId("select id from Unitofmeasure where name = '" + uomName + "'");
        }
    }
}
