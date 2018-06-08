using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bills.Classes
{

    class MainHelper
    {
        static SqlConnection conn = null;
        static SqlCommand comm = null;

        public static string DateForSql(DateTime date)
        {
            StringBuilder dateStr = new StringBuilder();

            dateStr.Append(date.Year);
            if (date.Month < 10)
                dateStr.Append("0" + date.Month);
            else
                dateStr.Append(date.Month);

            if (date.Day < 10)
                dateStr.Append("0" + date.Day);
            else
                dateStr.Append(date.Day);


            return dateStr.ToString();
        }

        public static string GetOneValue(string sql)
        {
            string value = String.Empty;
            conn = new SqlConnection(Form1.connString);
            comm = new SqlCommand(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                value = comm.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }

            return value;
        }

        public static string DecimalForSql(Decimal value)
        {
            string decimalStr = value.ToString();
            StringBuilder decimalSql = new StringBuilder();

            foreach (Char num in decimalStr)
            {
                if (num == ',')
                    decimalSql.Append(".");
                else
                    decimalSql.Append(num);
            }

            return decimalSql.ToString();
        }

        public static Decimal SqlStringIntoDecimal(String value)
        {
            string decimalStr = value.ToString();
            StringBuilder decimalSql = new StringBuilder();

            foreach (Char num in decimalStr)
            {
                if (num == ',')
                    decimalSql.Append("");
                else if (num == '.')
                    decimalSql.Append(",");
                else
                    decimalSql.Append(num);
            }

            return Convert.ToDecimal(decimalSql.ToString());
        }

        public static string DecimalFormat(Decimal value)
        {
            
            return string.Format("{0:C2}", Convert.ToDecimal(value));

        }

    }
}
