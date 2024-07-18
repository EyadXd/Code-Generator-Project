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
    public class clsDataBase
    {
        public string DataBaseName { get; set; }
        public BindingList<clsTable> Tables = new BindingList<clsTable>();

        public clsDataBase(string dataBaseName)
        {
            this.DataBaseName = dataBaseName;
        }
        static public DataTable GetDataBaseNames()
        {
            return DataBaseDataAccess.GetDataBaseName();
        }
        static public bool IsExists(string dataBaseName)
        {
            return DataBaseDataAccess.IsExists(dataBaseName);
        }
        static public bool DeleteDataBase(string Databasename)
        {
            return DataBaseDataAccess.DeleteDataBase(Databasename);
        }

    }
}
