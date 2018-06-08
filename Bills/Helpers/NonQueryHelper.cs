using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Bills.Classes;
using System.Data;
using System.Windows.Forms;

namespace Bills.Helpers
{
    class NonQueryHelper
    {
        #region Fields
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        #endregion

        private static void PrepareComponent()
        {
            conn = new SqlConnection(Form1.connString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        private static void Execute()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static void Insert(object data, string procName, int action)
        {

            PrepareComponent();
            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));

            switch (data.GetType().ToString())
            {
                case "Bills.Classes.BillBody": BuildBillBodyParameter((BillBody)data, "insert");
                    break;
                case "Bills.Classes.BillHead": BuildBillHeadParameter((BillHead)data, "insert");
                    break;
                case "Bills.Classes.Status": BuildStatusParameter((Status)data, "insert");
                    break;
                case "Bills.Classes.Store": BuildStoreParameter((Store)data, "insert");
                    break;
                case "Bills.Classes.City": BuildCityParameter((City)data, "insert");
                    break;
                case "Bills.Classes.Region": BuildRegionParameter((Region)data, "insert");
                    break;
                case "Bills.Classes.Country": BuildCountryParameter((Country)data, "insert");
                    break;
                case "Bills.Classes.BillCategory": BuildBillCatParameter((BillCategory)data, "insert");
                    break;
                case "Bills.Classes.BillPurpose": BuildBillPurpParameter((BillPurpose)data, "insert");
                    break;
                case "Bills.Classes.Uom": BuildUomParameter((Uom)data, "insert");
                    break;
                case "Bills.Classes.IncomeCategory": BuildIncCatParameter((IncomeCategory)data, "insert");
                    break;
                case "Bills.Classes.IncomePaymen": BuildIncPayParameter((IncomePaymen)data, "insert");
                    break;
                case "Bills.Classes.Income": BuildIncParameter((Income)data, "insert");
                    break;
                case "Bills.Classes.Plan": BuildPlanParameter((Plan)data, "insert");
                    break;
                default:
                    break;
            }

            Execute();

        }

        public static void Update(object data, string procName, int action)
        {

            PrepareComponent();
            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));

            switch (data.GetType().ToString())
            {
                case "Bills.Classes.BillBody": BuildBillBodyParameter((BillBody)data, "update");
                    break;
                case "Bills.Classes.BillHead": BuildBillHeadParameter((BillHead)data, "update");
                    break;
                case "Bills.Classes.Status": BuildStatusParameter((Status)data, "update");
                    break;
                case "Bills.Classes.Store": BuildStoreParameter((Store)data, "update");
                    break;
                case "Bills.Classes.City": BuildCityParameter((City)data, "update");
                    break;
                case "Bills.Classes.Region": BuildRegionParameter((Region)data, "update");
                    break;
                case "Bills.Classes.Country": BuildCountryParameter((Country)data, "update");
                    break;
                case "Bills.Classes.BillCategory": BuildBillCatParameter((BillCategory)data, "update");
                    break;
                case "Bills.Classes.BillPurpose": BuildBillPurpParameter((BillPurpose)data, "update");
                    break;
                case "Bills.Classes.Uom": BuildUomParameter((Uom)data, "update");
                    break;
                case "Bills.Classes.IncomePaymen": BuildIncPayParameter((IncomePaymen)data, "update");
                    break;
                case "Bills.Classes.IncomeCategory": BuildIncCatParameter((IncomeCategory)data, "update");
                    break;
                case "Bills.Classes.Income": BuildIncParameter((Income)data, "update");
                    break;
                case "Bills.Classes.Plan": BuildPlanParameter((Plan)data, "update");
                    break;
                default:
                    break;
            }

            Execute();

        }

        public static void DeleteOnId(string procName, int action, int id)
        {
            PrepareComponent();
            cmd.CommandText = procName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            cmd.Parameters.Add(new SqlParameter("@id", id));

            Execute();

        }

        #region Build Parameters
        private static void BuildBillBodyParameter(BillBody body, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", body.Id));
            
            cmd.Parameters.Add(new SqlParameter("@Headid", body.HeadId));
            cmd.Parameters.Add(new SqlParameter("@articl", body.Articl));
            cmd.Parameters.Add(new SqlParameter("@quantity", body.Quantity));
            cmd.Parameters.Add(new SqlParameter("@uomID", body.UomID));
            cmd.Parameters.Add(new SqlParameter("@sum", body.Sum));
            cmd.Parameters.Add(new SqlParameter("@pdv", body.Pdv));
            cmd.Parameters.Add(new SqlParameter("@description", body.Description));
        }

        private static void BuildBillHeadParameter(BillHead head, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", head.Id));

            cmd.Parameters.Add(new SqlParameter("@billNumber", head.BillNumber));
            cmd.Parameters.Add(new SqlParameter("@billDate", head.BillDate));
            cmd.Parameters.Add(new SqlParameter("@billCategoryID", head.BillCategoryID));
            cmd.Parameters.Add(new SqlParameter("@billPurposeID", head.BillPurposeID));
            cmd.Parameters.Add(new SqlParameter("@storeID", head.StoreID));
            cmd.Parameters.Add(new SqlParameter("@totalSum", head.TotalSum));
            cmd.Parameters.Add(new SqlParameter("@totalPdv", head.TotalPdv));
            cmd.Parameters.Add(new SqlParameter("@description", head.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", head.StatusID));

        }

        private static void BuildStatusParameter(Status status, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", status.Id));

            cmd.Parameters.Add(new SqlParameter("@name", status.Name));
        }

        private static void BuildStoreParameter(Store store, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", store.Id));

            cmd.Parameters.Add(new SqlParameter("@Name", store.Name));
            cmd.Parameters.Add(new SqlParameter("@Adress", store.Adress));
            cmd.Parameters.Add(new SqlParameter("@Phone", store.Phone));
            cmd.Parameters.Add(new SqlParameter("@CityID", store.CityID));
            cmd.Parameters.Add(new SqlParameter("@Web", store.Web));
            cmd.Parameters.Add(new SqlParameter("@description", store.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", store.StatusID));

        }

        private static void BuildCityParameter(City city, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", city.Id));

            cmd.Parameters.Add(new SqlParameter("@name", city.Name));
            cmd.Parameters.Add(new SqlParameter("@ponumber", city.PoNumber));
            cmd.Parameters.Add(new SqlParameter("@regionid", city.RegionId));
        }

        private static void BuildRegionParameter(Region region, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", region.Id));

            cmd.Parameters.Add(new SqlParameter("@name", region.Name));
            cmd.Parameters.Add(new SqlParameter("@countryid", region.CountryId));
        }

        private static void BuildCountryParameter(Country country, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", country.Id));

            cmd.Parameters.Add(new SqlParameter("@name", country.Name));
        }

        private static void BuildBillCatParameter(BillCategory billCat, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", billCat.Id));

            cmd.Parameters.Add(new SqlParameter("@name", billCat.Name));
            cmd.Parameters.Add(new SqlParameter("@description", billCat.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", billCat.StatusID));

        }

        private static void BuildBillPurpParameter(BillPurpose billpurp, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", billpurp.Id));

            cmd.Parameters.Add(new SqlParameter("@name", billpurp.Name));
            cmd.Parameters.Add(new SqlParameter("@description", billpurp.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", billpurp.StatusID));

        }

        private static void BuildUomParameter(Uom uom, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", uom.Id));

            cmd.Parameters.Add(new SqlParameter("@name", uom.Name));
            cmd.Parameters.Add(new SqlParameter("@description", uom.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", uom.StatusID));

        }

        private static void BuildIncCatParameter(IncomeCategory incCat, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", incCat.Id));

            cmd.Parameters.Add(new SqlParameter("@name", incCat.Name));
            cmd.Parameters.Add(new SqlParameter("@description", incCat.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", incCat.StatusID));

        }

        private static void BuildIncPayParameter(IncomePaymen incPay, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", incPay.Id));

            cmd.Parameters.Add(new SqlParameter("@name", incPay.Name));
            cmd.Parameters.Add(new SqlParameter("@description", incPay.Description));
            cmd.Parameters.Add(new SqlParameter("@statusid", incPay.StatusID));

        }

        private static void BuildIncParameter(Income income, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", income.Id));

            cmd.Parameters.Add(new SqlParameter("@date", income.Date));
            cmd.Parameters.Add(new SqlParameter("@incomePay", income.PaymenID));
            cmd.Parameters.Add(new SqlParameter("@incomeCat", income.CategoryID));
            cmd.Parameters.Add(new SqlParameter("@amount", income.Amount));
            cmd.Parameters.Add(new SqlParameter("@description", income.Description));
        }

        private static void BuildPlanParameter(Plan plan, string statement)
        {
            if (statement == "update")
                cmd.Parameters.Add(new SqlParameter("@id", plan.Id));

            cmd.Parameters.Add(new SqlParameter("@date", plan.PlanDate));
            cmd.Parameters.Add(new SqlParameter("@planYear", plan.PlanYear));
            cmd.Parameters.Add(new SqlParameter("@planMounth", plan.PlanMonth));
            cmd.Parameters.Add(new SqlParameter("@purposeID", plan.PurposeID));
            cmd.Parameters.Add(new SqlParameter("@categoryID", plan.CategoryID));
            cmd.Parameters.Add(new SqlParameter("@amount", plan.Amount));
            cmd.Parameters.Add(new SqlParameter("@description", plan.Description));
        }
        #endregion
    }
}
