using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bills.Classes
{
    public class Income : Classes.Base
    {
        #region Fields
        private string _description = String.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        

        private int _paymenID;
        public int PaymenID
        {
            get { return _paymenID; }
            set { _paymenID = value; }
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
        public Income()
        {
           
        }

        public Income(int id, string name)
            : base(id, name)
        {

        }
        #endregion


        public void Save(Income income)
        {
            try
            {
                Helpers.NonQueryHelper.Insert(income, "spIncome", 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(Income income)
        {
            try
            {
                Helpers.NonQueryHelper.DeleteOnId("spIncome", 4, income.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(Income income)
        {
            try
            {
                Helpers.NonQueryHelper.Update(income, "spIncome", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetCategoryId(Income income, string name)
        {
            income.CategoryID = Helpers.ReaderHelper.SelectId("select id from IncomeCategory where name = '" + name + "'");
            //Update(income);
        }

        public void SetPaymenId(Income income, string name)
        {
            income.PaymenID = Helpers.ReaderHelper.SelectId("select id from IncomePaymen where name = '" + name + "'");
            //Update(income);
        }
    }
}
