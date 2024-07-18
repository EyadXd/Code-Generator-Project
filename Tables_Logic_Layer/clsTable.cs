using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tables_Data_Layer;
using System.ComponentModel;

namespace Tables_Logic_Layer
{
    public class clsTable
    {

        public string TableName { set; get; }
        public BindingList<clsColumn> Columns = new BindingList<clsColumn>();

        public bool AddNew = false;
        public bool ListAll = false;
        public bool Update = false;
        public clsTable (string tableName)
        {
            TableName = tableName;
        }

       
        static public DataTable GetTablesNames()
        {
            return TableDataAccess.GetTablesNames();
        }
        static public bool IsExists(string TableName)
        {
            return TableDataAccess.IsExists(TableName);
        }
    }
}
