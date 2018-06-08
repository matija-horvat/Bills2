using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Bills.Classes
{
    public class Base
    {
        #region Fields
        private string sqlText = String.Empty;

        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _name = String.Empty;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Ctor
        public Base()
        {
            
        }

        public Base(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        #endregion
    }
}
