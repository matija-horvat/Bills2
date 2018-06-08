using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Bills.Classes;

namespace Bills.Helpers
{
    class ReaderHelper
    {
        #region Fields
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader reader = null;
        public static SqlDataAdapter adapter = null;
        public static DataSet ds = null;
        #endregion


        private static void PrepareComponent()
        {
            conn = new SqlConnection(Form1.connString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        private static void Commit(ref DataGridView grid, string table)
        {
            adapter = new SqlDataAdapter(cmd);

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                ds = new DataSet();
                adapter.Fill(ds, table);
                conn.Close();
                grid.DataSource = ds;
                grid.DataMember = table;
                grid.AutoGenerateColumns = true;
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static BillHead SelectHeadOnId(string procName, int action, int id)
        {
            BillHead head = new BillHead();

            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    head.Id = (int)reader.GetSqlInt32(0);
                    head.BillNumber = reader.GetString(1);
                    head.BillDate = (DateTime)reader.GetSqlDateTime(2);
                    head.StoreID = (int)reader.GetSqlInt32(3);
                    head.BillCategoryID = (int)reader.GetSqlInt32(4);
                    head.BillPurposeID = (int)reader.GetSqlInt32(5);
                    
                    if(!reader.GetSqlMoney(6).IsNull)
                        head.TotalSum = System.Convert.ToDecimal(reader.GetSqlMoney(6).ToString());
                    if (!reader.GetSqlMoney(7).IsNull)
                        head.TotalPdv = System.Convert.ToDecimal(reader.GetSqlMoney(7).ToString());
                    head.Description = reader.GetString(8);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                reader.Close();
                conn.Close();
            }
            

            return head;
        }

        public static BillBody SelectBodyOnId(string procName, int action, int id)
        {
            BillBody body = new BillBody();

            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    body.Articl = reader.GetString(0);
                    body.UomID = (int)reader.GetSqlInt32(1);
                    if (!reader.GetSqlMoney(3).IsNull)
                        body.Quantity = System.Convert.ToDecimal(reader.GetSqlMoney(3).ToString());
                    if (reader.GetString(4).Length > 0)
                        body.Sum = MainHelper.SqlStringIntoDecimal(reader.GetString(4));
                    if (reader.GetString(5).Length > 0)
                        body.Pdv = MainHelper.SqlStringIntoDecimal(reader.GetString(5));

                    body.Description = reader.GetString(6);
                    body.Id = (int)reader.GetSqlInt32(7);
                    body.HeadId = (int)reader.GetSqlInt32(8);

                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
                conn.Close();
            }


            return body;
        }

        public static object SelectObjectOnId(object obj, string procName, int action, int id)
        {
            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();

                switch (obj.GetType().ToString())
                {
                    case "Bills.Classes.Status": BindStatusProperties((Status)obj,ref reader);
                        break;
                    case "Bills.Classes.Store": BindStoreProperties((Store)obj,ref reader);
                        break;
                    case "Bills.Classes.City": BindCityProperties((City)obj,ref reader);
                        break;
                    case "Bills.Classes.Region": BindRegionProperties((Region)obj,ref reader);
                        break;
                    case "Bills.Classes.Country": BindCountryProperties((Country)obj,ref reader);
                        break;
                    case "Bills.Classes.BillCategory": obj = BindCategoryProperties((BillCategory)obj, ref reader);
                        break;
                    case "Bills.Classes.BillPurpose": obj = BindPurposeProperties((BillPurpose)obj,ref reader);
                        break;
                    case "Bills.Classes.Uom": BindUomProperties((Uom)obj,ref reader);
                        break;
                    case "Bills.Classes.IncomeCategory": obj = BindIncomeCategoryProperties((IncomeCategory)obj, ref reader);
                        break;
                    case "Bills.Classes.IncomePaymen": obj = BindIncomePaymenProperties((IncomePaymen)obj, ref reader);
                        break;
                    case "Bills.Classes.Plan": obj = BindPlanProperties((Plan)obj, ref reader);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
                conn.Close();
            }

            return obj;
        }

        public static BillCategory SelectCategoryOnId(string procName, int action, int id)
        {
            BillCategory billC = new BillCategory();

            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    billC.Name = reader.GetString(0);
                    billC.Description = reader.GetString(1);
                    billC.StatusID = (int)reader.GetInt32(2);
                    billC.Id = (int)reader.GetSqlInt32(3);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
                conn.Close();
            }

            return billC;
        }

        private static Status BindStatusProperties(Status obj, ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.ForeColorGrid = reader.GetString(1);
                obj.ForeColorGrid = reader.GetString(2);
                obj.Id = (int)reader.GetSqlInt32(3);
            }

            return obj;
        }

        private static Store BindStoreProperties(Store obj, ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                if (!reader.GetSqlString(1).IsNull)
                    obj.Adress = reader.GetString(1);
                if (!reader.GetSqlString(3).IsNull)
                    obj.Web = reader.GetString(3);
                if (!reader.GetSqlString(4).IsNull)
                    obj.Phone = reader.GetString(4);
                if (!reader.GetSqlString(5).IsNull)
                    obj.Description = reader.GetString(5);

                obj.Id = (int)reader.GetSqlInt32(7);

                if (!reader.GetSqlInt32(8).IsNull)
                    obj.CityID = (int)reader.GetSqlInt32(8);
                if (!reader.GetSqlInt32(9).IsNull)
                    obj.StatusID = (int)reader.GetSqlInt32(9);
            }

            return obj;
        }

        private static City BindCityProperties(City obj, ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.PoNumber = reader.GetString(1);
                obj.Id = (int)reader.GetSqlInt32(3);
                obj.RegionId = (int)reader.GetSqlInt32(4);
            }

            return obj;
        }

        private static Region BindRegionProperties(Region obj,ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.Id = (int)reader.GetSqlInt32(2);
                obj.CountryId = (int)reader.GetSqlInt32(3);
            }

            return obj;
        }

        private static Country BindCountryProperties(Country obj,ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.Id = (int)reader.GetSqlInt32(1);
            }

            return obj;
        }

        private static BillPurpose BindPurposeProperties(BillPurpose obj,ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                if (!reader.GetSqlString(1).IsNull)
                    obj.Description = reader.GetString(1);

                obj.Id = (int)reader.GetSqlInt32(3);

                if (!reader.GetSqlInt32(4).IsNull)
                    obj.StatusID = (int)reader.GetInt32(4);
            }

            return obj;
        }

        private static BillCategory BindCategoryProperties(BillCategory obj,ref SqlDataReader reader)
        {

            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.Description = reader.GetString(1);

                obj.Id = (int)reader.GetSqlInt32(2);

                if (!reader.GetSqlInt32(3).IsNull)
                    obj.StatusID = (int)reader.GetInt32(3);
            }

            return obj;
        }

        private static Uom BindUomProperties(Uom obj, ref SqlDataReader reader)
        {
            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                if (!reader.GetSqlString(1).IsNull)
                    obj.Description = reader.GetString(1);

                obj.Id = (int)reader.GetSqlInt32(3);

                if (!reader.GetSqlInt32(4).IsNull)
                    obj.StatusID = (int)reader.GetSqlInt32(4);
            }

            return obj;
        }

        private static IncomeCategory BindIncomeCategoryProperties(IncomeCategory obj, ref SqlDataReader reader)
        {

            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.Description = reader.GetString(1);

                obj.Id = (int)reader.GetSqlInt32(2);

                if (!reader.GetSqlInt32(3).IsNull)
                    obj.StatusID = (int)reader.GetInt32(3);
            }

            return obj;
        }

        private static IncomePaymen BindIncomePaymenProperties(IncomePaymen obj, ref SqlDataReader reader)
        {

            while (reader.Read())
            {
                obj.Name = reader.GetString(0);
                obj.Description = reader.GetString(1);

                obj.Id = (int)reader.GetSqlInt32(2);

                if (!reader.GetSqlInt32(3).IsNull)
                    obj.StatusID = (int)reader.GetInt32(3);
            }

            return obj;
        }

        private static Plan BindPlanProperties(Plan obj, ref SqlDataReader reader)
        {

            while (reader.Read())
            {
                if (!reader.GetSqlInt32(3).IsNull)
                    obj.PlanYear = (int)reader.GetSqlInt32(0);
                if (!reader.GetSqlInt32(3).IsNull)
                    obj.PlanMonth = (int)reader.GetSqlInt32(1);
                if (!reader.GetSqlInt32(3).IsNull)
                    obj.CategoryID = (int)reader.GetSqlInt32(2);
                if (!reader.GetSqlInt32(3).IsNull)
                    obj.PurposeID = (int)reader.GetSqlInt32(3);
                obj.Amount = reader.GetDecimal(4).ToString();
                obj.Description = reader.GetString(5);

                obj.Id = (int)reader.GetSqlInt32(6);
            }

            return obj;
        }

        public static int SelectId(string sql)
        {
            int id = 0;

            PrepareComponent();

            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                id = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }

            return id;
        }

        public static void BindBillHeadOnNode(string procName, int action, string node, ref DataGridView grid, string table)
        {
            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@node", node));

            Commit(ref grid, table);
        }

        public static void BindBillBodyOnId(string procName, int action, int id, ref DataGridView grid, string table)
        {
            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            Commit(ref grid, table);

            grid.AutoSize = false;
            grid.Columns[0].Width = 200;
            grid.Columns[1].Width = 100;
            grid.Columns[2].Width = 100;
            grid.Columns[3].Width = 100;
            grid.Columns[4].Width = 200;

        }

        public static void RefreshGrid(ref DataGridView grid, SqlDataAdapter adapter, string srcTable)
        {
            PrepareComponent();

            if (grid.DataSource != null)
            {
                grid.DataSource = null;
            }
            else
            {
                grid.Rows.Clear();
            }

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                ds = new DataSet();
                adapter.Fill(ds, srcTable);
                conn.Close();
                grid.DataSource = ds;
                grid.DataMember = srcTable;
                grid.AutoGenerateColumns = true;
                conn.Close();

                grid.AutoSize = false;
                //grid.Columns[0].Width = 300;
                grid.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public static void BindGrid(ref DataGridView grid, string procName, int action, string srcTable)
        {
            PrepareComponent();

            if (grid.DataSource != null)
            {
                grid.DataSource = null;
            }
            else
            {
                grid.Rows.Clear();
            }

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));

            adapter = new SqlDataAdapter(cmd);
            BindingSource source = new BindingSource();
            DataTable table = new DataTable();

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                adapter.Fill(table);
                conn.Close();
                source.DataSource = table;
                grid.DataSource = source;

                grid.AutoGenerateColumns = true;
                
                grid.AutoSize = false;
                if (grid.Columns["id"] != null)
                {
                    grid.Columns["id"].Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid">Grid to populate.</param>
        /// <param name="procName">Stored procedure name.</param>
        /// <param name="action">Action in sql procedure.</param>
        /// <param name="param">This is value int parameter for stored procedure.</param>
        /// <param name="srcTable">Source table for dataset.</param>
        public static void BindGrid(ref DataGridView grid, string procName, int action, int param, string srcTable)
        {
            PrepareComponent();

            if (grid.DataSource != null)
            {
                grid.DataSource = null;
            }
            else
            {
                grid.Rows.Clear();
            }
            
            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@param", param));

            adapter = new SqlDataAdapter(cmd);
            BindingSource source = new BindingSource();
            DataTable table = new DataTable();

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                adapter.Fill(table);
                conn.Close();
                source.DataSource = table;
                grid.DataSource = source;

                grid.AutoGenerateColumns = true;

                grid.AutoSize = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid">Grid to populate.</param>
        /// <param name="procName">Stored procedure name.</param>
        /// <param name="action">Action in sql procedure.</param>
        /// <param name="param">This is value int parameter for stored procedure.</param>
        /// <param name="srcTable">Source table for dataset.</param>
        public static void BindGrid(ref DataGridView grid, string procName, int action,string[] paramListNames, object[] paramListValues, string srcTable)
        {
            PrepareComponent();

            if (grid.DataSource != null)
            {
                grid.DataSource = null;
            }
            else
            {
                grid.Rows.Clear();
            }

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));

            for (int i = 0; i < paramListNames.Length; i++)
			{
			    cmd.Parameters.Add(new SqlParameter(paramListNames[i], paramListValues[i]));
			}
           
            adapter = new SqlDataAdapter(cmd);
            BindingSource source = new BindingSource();
            DataTable table = new DataTable();

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                adapter.Fill(table);
                conn.Close();
                source.DataSource = table;
                grid.DataSource = source;

                grid.AutoGenerateColumns = true;

                grid.AutoSize = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public static void RefreshComboBox(string sql, ref ComboBox combo, string table, string display, string value)
        {
            PrepareComponent();

            adapter = new SqlDataAdapter(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                ds = new DataSet();
                adapter.Fill(ds, table);
                conn.Close();

                combo.DataSource = ds.Tables[table];
                combo.DisplayMember = display;
                combo.ValueMember = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// This procedure is used for fill DataTable for diagram.
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="action"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string procName, int action, Nullable<int> year, Nullable<int> month, Nullable<int> day)
        {
            PrepareComponent();

            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@year", year));
            cmd.Parameters.Add(new SqlParameter("@month", month));
            cmd.Parameters.Add(new SqlParameter("@day", day));

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            DataTable dtGet = new DataTable();

            try
            {

                da.Fill(dataSet);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    dataSet.Tables[0].TableName = "BillBody";
                }

                dtGet = dataSet.Tables[0];
                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dtGet;

        }
    }
}
