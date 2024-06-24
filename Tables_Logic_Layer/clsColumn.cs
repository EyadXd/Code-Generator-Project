using System.Collections.Generic;
using System.Data;
using Tables_Data_Layer;
using System;
using System.ComponentModel;

namespace Tables_Logic_Layer
{
    public class clsColumn
    {
        //Column Properties 
        public string COLUMN_NAME { set; get; }
        public string DATA_TYPE { set; get; }
        public int CHARACTER_MAXIMUM_LENGTH { set; get; }
        public bool IsNullable { set; get; }
        public bool IsIdentity { set; get; }
        public bool IsPrimaryKey { set; get; }


        //Column Code Writting Options
        public bool Find_By { set; get; } = false;
        public bool Delete_By { set; get; }  = false;
        public bool IsExists_By { set; get; }= false;


        public clsColumn(string COLUMNNAME, string DATATYPE, int CHARACTERMAXIMUMLENGTH, bool isNullable, bool isIdentity, bool isPrimaryKey, bool findBy, bool deleteBy, bool isExistsBy)
        {
            COLUMN_NAME = COLUMNNAME;
            DATA_TYPE = DATATYPE;
            CHARACTER_MAXIMUM_LENGTH = CHARACTERMAXIMUMLENGTH;
            IsNullable = isNullable;
            IsIdentity = isIdentity;
            IsPrimaryKey = isPrimaryKey;
            Find_By = findBy;
            Delete_By = deleteBy;
            IsExists_By = isExistsBy;
        }

        static public DataTable GetColumnsNames(string TableName)
        {
            return ColumnDataAccess.GetColumnsNames(TableName);
        }

        static public bool IsExists(string TableName, string ColumnName)
        {
            return ColumnDataAccess.IsExists(TableName, ColumnName);
        }

        static public BindingList<clsColumn> ListColumns(string TableName)
        {
            BindingList<clsColumn> Columns = new BindingList<clsColumn>();

            DataTable table =  ColumnDataAccess.ListColumns(TableName);

            foreach(DataRow Row in table.Rows)
            {
                Columns.Add(new clsColumn(Convert.ToString(Row["COLUMN_NAME"]), Convert.ToString(Row["DATA_TYPE"]), Convert.ToInt32(Row["CHARACTER_MAXIMUM_LENGTH"] == DBNull.Value ? 0 : Row["CHARACTER_MAXIMUM_LENGTH"]), Convert.ToBoolean(Row["IsNullable"]), Convert.ToBoolean(Row["IsIdentity"]), Convert.ToBoolean(Row["IsPrimaryKey"]), false, false, false));
            }

            return Columns;
        }

    }
}
