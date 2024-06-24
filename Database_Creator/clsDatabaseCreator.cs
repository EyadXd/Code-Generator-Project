using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables_Logic_Layer;
using System.Data.SqlClient;
using General_Settings;

namespace Database_Creator
{
    static public class clsDatabaseCreator
    {
        static string _ColumnIdentity(clsColumn column)
        {
            if(column.IsIdentity)
            {
                return "IDENTITY(1,1)";
            }
            else
            {
                return "";
            }
        }
        static string _ColumnNullable(clsColumn column)
        {
            if(column.IsNullable)
            {
                return "Null";
            }
            else
            {
                return "Not Null";
            }
        }
        static string _ColumnPrimaryKey(clsColumn column)
        {
            if(column.IsPrimaryKey)
            {
                return "Primary Key";
            }
            else
            {
                return "";
            }
        }
        static string _ColumnDataType(clsColumn column)
        {
            if(column.CHARACTER_MAXIMUM_LENGTH!=0)
            {
                return $"{column.DATA_TYPE}({column.CHARACTER_MAXIMUM_LENGTH})";
            }
            else
            {
                return column.DATA_TYPE;
            }
        }
        static private string _Create_Columns_Querey(clsTable Table)
        {
            string Qeuery = "";

            foreach(clsColumn Column in Table.Columns)
            {
                Qeuery += $@"{Column.COLUMN_NAME} {_ColumnDataType(Column)} {_ColumnPrimaryKey(Column)} {_ColumnNullable(Column)} {_ColumnIdentity(Column)},";
            }

            return Qeuery.TrimEnd(',');
        }
        static private bool _Create_Table(clsTable Table)
        {
            string connectionString =clsConnectionInfos.ConnectionString();
            string ColumnsQeuery = _Create_Columns_Querey(Table);

            string createTableQuery = $@"
            CREATE TABLE [{Table.TableName}] (
              {ColumnsQeuery}
            )";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        static private bool _Create_DataBase(clsDataBase DataBase)
        {
            string connectionString = $"Server={clsConnectionInfos.ServerName};User ID={clsConnectionInfos.UserID};Password={clsConnectionInfos.Password};";

            string createDatabaseQuery = $"CREATE DATABASE [{DataBase.DataBaseName}]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        static public bool Create(clsDataBase dataBase)
        {

            if(_Create_DataBase(dataBase))
            {
                foreach(clsTable Table in dataBase.Tables)
                {
                    if(!_Create_Table(Table))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
