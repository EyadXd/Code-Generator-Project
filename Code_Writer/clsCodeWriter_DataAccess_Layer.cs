using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables_Logic_Layer;
using General_Settings;

namespace Code_Writer
{
    static public class clsCodeWriter_DataAccess_Layer
    {
        private static string _Write_Comment(string Value)
        {
            return $"/*         {Value}         */";
        }
        private static string _Write_NameSpaces(clsTable table)
        {
            string NameSpace = $"{table.TableName}_DataAccess";

            string Code = $@"using System;
                             using System.Data.SqlClient;
                             using System.Data;
                             
                             namespace {NameSpace}
                             {{
            ";
            return Code;
        }
        private static string _Write_ClassDefinition(clsTable table)
        {
            string Code = $@"public class clsData_{table.TableName}
                                 {{

                            ";
            return Code;
        }
        private static string _Write_NapeSpaces_End()
        {
            return @"
                        }
                    }";
        }

        // Add New
        private static string _Write_ParametarizedQeuery_AddNew(clsTable table)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)
            {
                if (!Column.IsPrimaryKey)
                {
                    if (Column.IsNullable)
                    {
                        Code += $@"command.Parameters.AddWithValue(""@{Column.COLUMN_NAME}"",(object){Column.COLUMN_NAME} ?? DBNull.Value);
                                   ";
                    }
                    else
                    {
                        Code += $@"command.Parameters.AddWithValue(""@{Column.COLUMN_NAME}"", {Column.COLUMN_NAME});
                                   ";
                    }
                }
            }

            return Code;
        }
        private static string _Write_InsertIntoColumnNames(clsTable table)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)//Insert To Column Names
            {
                if (!Column.IsPrimaryKey)
                {
                    Code += $@"[{Column.COLUMN_NAME}]
                          ,";
                }
            }

            return Code.TrimEnd(',');//Last Comma Delete
        }
        private static string _Write_InsertIntoColumnParametersNames(clsTable table)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)//Insert To Column Names
            {
                if (!Column.IsPrimaryKey)
                {
                    Code += $@"@{Column.COLUMN_NAME}
                          ,";
                }
            }

            return Code.Substring(0, Code.Length - 1);//Last Comma Delete
        }
        private static string _Write_Header_AddNew(clsTable table)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)
            {
                if (!Column.IsPrimaryKey)
                {
                    string ColumnType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(Column.DATA_TYPE);
                    Code += $@"{ColumnType} {Column.COLUMN_NAME},";
                }
            }

            return Code.TrimEnd(',');//Las Coma Delete
        }
        private static string _Write_Querey_AddNew(clsTable table)
        {
            string Code = "";
            string InsertIntoColunNames = _Write_InsertIntoColumnNames(table);
            string InsertIntoColumnParametersNames = _Write_InsertIntoColumnParametersNames(table);

            Code = $@"INSERT INTO {table.TableName}
                                   ({InsertIntoColunNames})
                             VALUES
                                   ({InsertIntoColumnParametersNames})
                        SELECT SCOPE_IDENTITY()";

            return Code;
        }
        public static string Write_AddNew(clsTable table)
        {

            if (table.Columns.Count == 0)
            {
                return "Add New Code Faild : No Columns";
            }
            if (table.Columns.Count(c => c.IsPrimaryKey) != 1)
            {
                return "Add New Code Faild : No Primary Key Or More Than One Primary Key";
            }
            if (!table.Columns.First(c=>c.IsPrimaryKey).IsIdentity)
            {
                return "Add New Code Faild : The primary Key Is Not Identity (Auto Numeric)";
            }

            string Code = "";
            string VarHeadersValues = _Write_Header_AddNew(table);
            string ConnectionString = clsConnectionInfos.ConnectionString();
            string AddNewQeurey = _Write_Querey_AddNew(table);
            string ParametarizedQeurey = _Write_ParametarizedQeuery_AddNew(table);


            Code = $@"public static int AddNew({VarHeadersValues})
            {{
                int id = -1;

                string connectionString = ""{ConnectionString}"";
                string query = @""{AddNewQeurey}"";

            try
            {{
                using (SqlConnection connection = new SqlConnection(connectionString))
                {{
                using (SqlCommand command = new SqlCommand(query, connection))
                {{
                    {ParametarizedQeurey}

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedId))
                    {{
                        id = insertedId;
                    }}
                }}
                }}
            }}
            catch
            {{

            }}
        return id;
          }}";

            return Code;
        }


        // List All Columns
        public static string Write_ListRecords(clsTable table)
        {
            if (table.Columns.Count == 0)
            {
                return "List Code Faild : No Columns";
            }
            if (table.Columns.Count(c => c.IsPrimaryKey) != 1)
            {
                return "List Code Faild : No Primary Key Or More Than One Primary Key";
            }

            string Code = "";
            string ConnectionString = clsConnectionInfos.ConnectionString();

            Code = $@"static public DataTable ListAll_{table.TableName}()
            {{
            DataTable dt = new DataTable();
            string connectionString = ""{ConnectionString}"";
            string query = ""SELECT * FROM {table.TableName}"";

            try
            {{
                using (SqlConnection connection = new SqlConnection(connectionString))
                {{
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if (reader.HasRows)
                            {{
                                dt.Load(reader);
                            }}
                        }}
                    }}
                }}
            }}
            catch
            {{

            }}

            return dt;
            }}";

            return Code;
        }


        // Find_By
        private static string _Write_Header_Find(clsTable table, string FindByColumnName)
        {
            string Code = "";
            string FindByColumnType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(table.Columns.First(c => c.COLUMN_NAME == FindByColumnName).DATA_TYPE);

            Code += Code += $"{FindByColumnType} {FindByColumnName},";

            foreach (clsColumn Column in table.Columns)
            {
                string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(Column.DATA_TYPE);

                if (Column.COLUMN_NAME != FindByColumnName)
                {
                    Code += $"ref {DataType} {Column.COLUMN_NAME},";
                }
      
            }
            return Code.TrimEnd(',');
        }
        private static string Write_Reader_Find(clsTable table, string FindByColumnName)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)
            {
                if (Column.COLUMN_NAME != FindByColumnName)
                {
                    string ReaderFunction = clsDataManagement.Convert_DataType_To_SqlReaderFunction(Column.DATA_TYPE);
                    if (Column.IsNullable)
                    {
                        string DefualtValue = clsDataManagement.GetNullValue(Column.DATA_TYPE);
                        Code += $@"{Column.COLUMN_NAME} = reader.IsDBNull(reader.GetOrdinal(""{Column.COLUMN_NAME}"")) ?  {DefualtValue} : reader.{ReaderFunction}(reader.GetOrdinal(""{Column.COLUMN_NAME}""));
                            ";
                    }
                    else
                    {
                        Code += $@"{Column.COLUMN_NAME} = reader.{ReaderFunction}(reader.GetOrdinal(""{Column.COLUMN_NAME}""));
                            ";
                    }
                }
            }

            return Code;
        }
        public static string Write_FindBy(clsTable table, string FindByColumnName)
        {
            if (table.Columns.Count == 0)
            {
                return "FindBy Code Faild : No Columns";
            }
            if (table.Columns.Count(c => c.IsPrimaryKey) != 1)
            {
                return "FindBy Code Faild : No Primary Key Or More Than One Primary Key";
            }
            if (String.IsNullOrEmpty(FindByColumnName))
            {
                return "FindBy Code Faild : No Column Selected To Find With";
            }
            if(!table.Columns.Any(c => c.COLUMN_NAME == FindByColumnName))
            {
                return "FindBy Code Faild : FindByColumn Name Is Not Existed In Table";
            }
            if(table.Columns.First(c => c.COLUMN_NAME == FindByColumnName).IsNullable)
            {
                return "FindBy Code Faild : This Column Is Nullable";
            }


            string Code = "";
            string Header = _Write_Header_Find(table, FindByColumnName);
            string ConnectionString = clsConnectionInfos.ConnectionString();
            string Reader = Write_Reader_Find(table, FindByColumnName);


            Code = $@" static public bool FindBy{FindByColumnName}({Header})
        {{
            bool isFound = false;
            string connectionPath = ""{ConnectionString}""; 
            string query = ""SELECT * FROM {table.TableName} WHERE {table.TableName}.{FindByColumnName} = @{FindByColumnName}"";

            try
            {{
                using (SqlConnection connection = new SqlConnection(connectionPath))
                {{
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue(""@{FindByColumnName}"", {FindByColumnName});

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if (reader.Read())
                            {{
                                isFound = true;
                                {Reader};

                            }}
                        }}
                    }}
                }}
            }}
            catch
            {{
              
            }}

            return isFound;
        }}";

            return Code;
        }


        // Update 
        private static string _Write_ParametarizedQeuery_Update(clsTable table)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)
            {
                    if (Column.IsNullable)
                    {
                        Code += $@"command.Parameters.AddWithValue(""@{Column.COLUMN_NAME}"",(object){Column.COLUMN_NAME} ?? DBNull.Value);
                                   ";
                    }
                    else
                    {
                        Code += $@"command.Parameters.AddWithValue(""@{Column.COLUMN_NAME}"", {Column.COLUMN_NAME});
                                   ";
                    }
            }

            return Code;
        }
        private static string Write_Qeuery_Update(clsTable table)
        {
            string Code = $"UPDATE {table.TableName} SET ";
            string PrimaryColumnName = table.Columns.First(c => c.IsPrimaryKey).COLUMN_NAME;

            foreach (clsColumn Column in table.Columns)
            {
                if (Column.COLUMN_NAME != PrimaryColumnName)
                {
                    Code += $"{Column.COLUMN_NAME} = @{Column.COLUMN_NAME}, ";
                }
            }

            Code = Code.TrimEnd(',', ' ');

            Code += $" WHERE {PrimaryColumnName} = @{PrimaryColumnName}";

            return Code;
        }
        private static string Write_Header_Update(clsTable table)
        {
            string Code = "";

            clsColumn PrimaryColumn = table.Columns.First(c => c.IsPrimaryKey);

            Code += $"{clsDataManagement.Convert_DataType_From_SQL_To_Csharp(PrimaryColumn.DATA_TYPE)} {PrimaryColumn.COLUMN_NAME},"; // Main Column

            foreach (clsColumn Column in table.Columns)
            {
                string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(Column.DATA_TYPE);

                if(Column.COLUMN_NAME != PrimaryColumn.COLUMN_NAME)
                {
                    Code += $@"{DataType} {Column.COLUMN_NAME},";
                }
            }
            return Code.TrimEnd(',');
        }
        public static string Write_Update(clsTable table)
        {
            if (table.Columns.Count == 0)
            {
                return "UpdateBy Code Faild : No Columns";
            }
            if (table.Columns.Count(c => c.IsPrimaryKey) != 1)
            {
                return "UpdateBy Code Faild : No Primary Key Or More Than One Primary Key";
            }
            

            string Code = "";
            string Header = Write_Header_Update(table);
            string ConnectionString = clsConnectionInfos.ConnectionString();
            string Qeuery = Write_Qeuery_Update(table);
            string Parameters = _Write_ParametarizedQeuery_Update(table);

            Code = $@" static public int Update({Header})
        {{
            string connectionString = ""{ConnectionString}"";
            string query = @""
                              {Qeuery}
                             "";

            try
            {{
                using (SqlConnection connection = new SqlConnection(connectionString))
                {{
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        {Parameters}

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();
                        return affectedRows ;
                    }}
                }}
            }}
            catch 
            {{
                return 0;
            }}
        }}";

            return Code;
        }
        
        
        // Delete By
        public static string Write_DeleteBy(clsTable table , string DeleteByColumnName)
        {
            if (table.Columns.Count == 0)
            {
                return "DeleteBy Code Faild : No Columns";
            }
            if (table.Columns.Count(c => c.IsPrimaryKey) != 1)
            {
                return "DeleteBy Code Faild : No Primary Key Or More Than One Primary Key";
            }
            if (String.IsNullOrEmpty(DeleteByColumnName))
            {
                return "DeleteBy Code Faild : No Column Selected To Find With";
            }
            if (!table.Columns.Any(c => c.COLUMN_NAME == DeleteByColumnName))
            {
                return "DeleteBy Code Faild : DeleteByColumnName Name Is Not Existed In Table";
            }

            string Code = "";
            string ColumnDataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(table.Columns.First(c => c.COLUMN_NAME == DeleteByColumnName).DATA_TYPE);
            string ConnectionString = clsConnectionInfos.ConnectionString();


            Code = $@" static public int DeleteBy{DeleteByColumnName}({ColumnDataType} {DeleteByColumnName})
        {{
            string connectionString = ""{ConnectionString}"";
            string query = @""DELETE FROM {table.TableName} WHERE {DeleteByColumnName} = @{DeleteByColumnName}"";

            try
            {{
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {{
                    command.Parameters.AddWithValue(""@{DeleteByColumnName}"", {DeleteByColumnName});

                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows;
                
              }}
            }}
            catch
            {{
     
                return 0;
          }}
        }}";

            return Code;
        }


        // Is Exists By
        public static string Write_IsExists(clsTable table , string IsExistsByColumnName)
        {
            string Code = "";
            string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(table.Columns.First(c => c.COLUMN_NAME == IsExistsByColumnName).DATA_TYPE);
            string ConnectionString = clsConnectionInfos.ConnectionString();

            Code += $@"static public bool IsExistsBy{IsExistsByColumnName}({DataType} {IsExistsByColumnName})
{{
    string connectionString = ""{ConnectionString}"";
    string query = ""SELECT 1 FROM {table.TableName} WHERE {IsExistsByColumnName} = @{IsExistsByColumnName}"";

    try
    {{
        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {{
            command.Parameters.AddWithValue(""@{IsExistsByColumnName}"", {IsExistsByColumnName});

            connection.Open();
            object result = command.ExecuteScalar();
            return result != null;
        }}
    }}
    catch 
    {{
        return false;
    }}
}}";

            return Code;
        }
        
        

        //Final Method 
        public static string Write_Code(clsTable table)
        {
            string Code = "";

            Code += _Write_NameSpaces(table);
            Code += _Write_ClassDefinition(table);

            if (table.AddNew)
            {
                Code += _Write_Comment("Add New");
                Code += Write_AddNew(table);
                Code += @"

                           


                        ";
            }        
            if(table.ListAll)
            {
                Code += _Write_Comment("List Records");
                Code += Write_ListRecords(table);
                Code += @"

                           


                        ";
            }
            if(table.Update)
            {
                Code += _Write_Comment("Update");
                Code += Write_Update(table);
                Code += @"

                           


                        ";
            }
            foreach (clsColumn Column in table.Columns)
            {
                if (Column.Find_By || Column.Delete_By|| Column.IsExists_By)
                {
                    Code += _Write_Comment(Column.COLUMN_NAME);

                    if (Column.Find_By)
                    {
                        Code += Write_FindBy(table, Column.COLUMN_NAME);
                        Code += @"

                            ";
                    }
                    if (Column.Delete_By)
                    {
                        Code += Write_DeleteBy(table, Column.COLUMN_NAME);
                        Code += @"

                            ";
                    }
                    if (Column.IsExists_By)
                    {
                        Code += Write_IsExists(table, Column.COLUMN_NAME);
                        Code += @"

                            ";
                    }

                    Code += @"



                            ";
                }
            }

            Code += _Write_NapeSpaces_End();

            return Code;
        }
    }
}
