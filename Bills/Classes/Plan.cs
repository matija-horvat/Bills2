using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class Plan: Classes.Base
    {
        #region Fields
        private string _description = String.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime _planDate;
        public DateTime PlanDate
        {
            get { return _planDate; }
            set { _planDate = value; }
        }

        private int _planMonth;
        public int PlanMonth
        {
            get { return _planMonth; }
            set { _planMonth = value; }
        }

        private int _planYear;
        public int PlanYear
        {
            get { return _planYear; }
            set { _planYear = value; }
        }

        private int _purposeID;
        public int PurposeID
        {
            get { return _purposeID; }
            set { _purposeID = value; }
        }


        private int _categoryID;
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        #endregion

         #region Ctor
        public Plan()
        {
           
        }

        public Plan(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(Plan plan)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(plan, "spPlan", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Plan plan)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spPlan", 4, plan.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(Plan plan)
        {
            try
            {
                Helpers.NonQueryHelper.Update(plan, "spPlan", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetCategoryId(Plan plan, string name)
        {
            plan.CategoryID = Helpers.ReaderHelper.SelectId("select id from BillCategory where name = '" + name + "'");
            //Update(income);
        }

        public void SetPurposeId(Plan plan, string name)
        {
            plan.PurposeID = Helpers.ReaderHelper.SelectId("select id from BillPurpose where name = '" + name + "'");
            //Update(income);
        }


    }
}
