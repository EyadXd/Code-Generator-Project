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
            if (column.IsIdentity)
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
            if (column.IsNullable)
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
            if (column.IsPrimaryKey)
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
            if (column.CHARACTER_MAXIMUM_LENGTH == -1 && column.DATA_TYPE.Contains("varchar"))
            {
                return $"{column.DATA_TYPE}(MAX)";
            }

            if (column.CHARACTER_MAXIMUM_LENGTH != 0)
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

            foreach (clsColumn Column in Table.Columns)
            {
                Qeuery += $@"{Column.COLUMN_NAME} {_ColumnDataType(Column)} {_ColumnPrimaryKey(Column)} {_ColumnNullable(Column)} {_ColumnIdentity(Column)},";
            }

            return Qeuery.TrimEnd(',');
        }
        static private string _Add_Column_Description_Query(clsTable Table)
        {
            string descriptionQuery = "";

            foreach (clsColumn Column in Table.Columns)
            {
                if (!string.IsNullOrEmpty(Column.COLUMN_DESCRIPTION))
                {
                    descriptionQuery += $@"
            EXEC sp_addextendedproperty 
                @name = N'MS_Description', 
                @value = N'{Column.COLUMN_DESCRIPTION}', 
                @level0type = N'SCHEMA', @level0name = 'dbo', 
                @level1type = N'TABLE',  @level1name = '{Table.TableName}', 
                @level2type = N'COLUMN', @level2name = '{Column.COLUMN_NAME}';
            ";
                }
            }

            return descriptionQuery;
        }
        static private bool _Create_Table(clsTable Table)
        {
            string connectionString = clsConnectionInfos.ConnectionString();
            string ColumnsQeuery = _Create_Columns_Querey(Table);
            string AddColumnDescriptionQuery = _Add_Column_Description_Query(Table);

            string createTableQuery = $@"
    CREATE TABLE [{Table.TableName}] (
      {ColumnsQeuery}
    )";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // تنفيذ استعلام إنشاء الجدول
                    using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }

                    // تنفيذ استعلامات إضافة الأوصاف بشكل منفصل
                    if (!string.IsNullOrEmpty(AddColumnDescriptionQuery))
                    {
                        using (SqlCommand descriptionCommand = new SqlCommand(AddColumnDescriptionQuery, connection))
                        {
                            descriptionCommand.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                // يمكن التعامل مع الأخطاء هنا أو تسجيلها إذا لزم الأمر
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
            catch (Exception dd)
            {
                return false;
            }
        }


        static public bool Create(clsDataBase dataBase)
        {

            if (_Create_DataBase(dataBase))
            {
                foreach (clsTable Table in dataBase.Tables)
                {
                    if (!_Create_Table(Table))
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
