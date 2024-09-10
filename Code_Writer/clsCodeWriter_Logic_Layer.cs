using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables_Logic_Layer;
using General_Settings;

namespace Code_Writer
{
    static public class clsCodeWriter_Logic_Layer
    {
        static private string _Write_Comment(string Value)
        {
            return $"/*         {Value}         */";
        }
        static private string _Write_Namespaces(clsTable table)
        {
            string Code = "";

            Code = $@"using System;
                     using System.Collections.Generic;
                     using System.Linq;
                     using System.Text;
                     using System.Threading.Tasks;
                     using System.Data;
                     using {table.TableName}_DataAccess;
                     
                     namespace {table.TableName}_LogicLayer
                     {{
                         ";

            return Code;
        }
        static private string _Write_ClassDefintion(clsTable table)
        {
            string Code = $@" public class cls{table.TableName}
                             {{

                            ";

            return Code;
        }
        static private string _Write_ClosenameSpace()
        {
            return @"}
                        }";
        }

        //Properties
        static private string _Write_Properties_Definitions(clsTable table)
        {
            string Code = "";

            Code += @"public enum enMode { UpdateMode, AddNewMode };

                      public enMode Mode { private set; get; }
                      ";

            foreach (clsColumn column in table.Columns)
            {
                string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(column.DATA_TYPE);

                if (!String.IsNullOrEmpty(column.COLUMN_DESCRIPTION))
                    Code += _Write_Comment($"{column.COLUMN_DESCRIPTION}");

                if(!column.IsPrimaryKey)
                Code += $@"public {DataType} {column.COLUMN_NAME} {{ set; get; }}
                          ";
                else
                    Code += $@"public {DataType} {column.COLUMN_NAME} {{ private set; get; }}
                          ";
            }

            return Code;
        }
        static public string Write_Properties(clsTable table)
        {
            string Code = "";
            string Properties = _Write_Properties_Definitions(table);


            Code += _Write_Comment("Properties");
            Code += Properties;

            return Code;
        }


        //Private Constractor
        static private string _Write_VarFilling_PrivateConstractor(clsTable table)
        {
            string Code = "";

            Code += @"Mode = enMode.UpdateMode;
";

            foreach (clsColumn Column in table.Columns)
            {
                Code += $@"this.{Column.COLUMN_NAME} = {Column.COLUMN_NAME};
                          ";
            }

            return Code;
        }
        static private string _Write_Header_PrivateConstractor(clsTable table)
        {
            string Code = "";

            foreach (clsColumn Column in table.Columns)
            {
                string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(Column.DATA_TYPE);
                Code += $"{DataType} {Column.COLUMN_NAME},";
            }
            return Code.TrimEnd(',');
        }
        static public string Write_Constractor_Private(clsTable table)
        {
            string Code = "";
            string Header = _Write_Header_PrivateConstractor(table);
            string VarsFilling = _Write_VarFilling_PrivateConstractor(table);

            Code = $@"private cls{table.TableName}({Header})
        {{
                    {VarsFilling}
        }}
        ";

            return Code;
        }


        //Public COnstractor
        static private string _Write_VarFilling_PublicConstractor(clsTable table)
        {
            string Code = "";

            Code += @"Mode = enMode.AddNewMode;
                    ";

            foreach (clsColumn Column in table.Columns)
            {
                string DefValue = clsDataManagement.GetDefaultValue(Column.DATA_TYPE);
                Code += $@"this.{Column.COLUMN_NAME} = {DefValue};
                          ";
            }

            return Code;
        }
        static public string Write_Constractor_Public(clsTable table)
        {
            string Code = "";
            string VarFilling = _Write_VarFilling_PublicConstractor(table);

            Code = $@"public cls{table.TableName}()
        {{
            {VarFilling}
        }}

        ";

            return Code;
        }

        //Delete By

        static public string Write_DeleteBy(clsTable table,string DeleteByColumnName)
        {
            string Code = "";
            string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(table.Columns.First(c => c.COLUMN_NAME == DeleteByColumnName).DATA_TYPE);
            
            Code = $@"static public int DeleteBy{DeleteByColumnName}({DataType} {DeleteByColumnName})
                     {{
                         return clsData_{table.TableName}.DeleteBy{DeleteByColumnName}({DeleteByColumnName});
                     }}";

            return Code;
        }


        //List All Records 
        static public string Write_ListAllRecords(clsTable table)
        {
            string Code = "";

             Code = $@"static public DataTable ListAll_{table.TableName}()
                             {{
                                 return clsData_{table.TableName}.ListAll_{table.TableName}();
                             }}";

            return Code; ;
        }


        //Is Exists By
        static public string Write_IsExistsBy(clsTable table, string IsExitsByColumnName)
        {
            string Code = "";
            string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(table.Columns.First(c => c.COLUMN_NAME == IsExitsByColumnName).DATA_TYPE);

            Code = $@"static public bool IsExistsBy{IsExitsByColumnName}({DataType} {IsExitsByColumnName})
        {{
            return clsData_{table.TableName}.IsExistsBy{IsExitsByColumnName}({IsExitsByColumnName});
        }}";

            return Code;
        }

        //Find By
        static private string _Write_SendParametersToConstactors_Find(clsTable table,string FindByColumnName)
        {
            string Code = "";


            foreach (clsColumn column in table.Columns)
            {
                if (column.COLUMN_NAME == FindByColumnName)
                {
                    Code += $@"{column.COLUMN_NAME},";
                }
                else
                {
                    Code += $@"{column.COLUMN_NAME.ToLower()},";
                }
            }

            return Code.TrimEnd(',');
        }
        static private string _Write_ParametersSendTo_Find(clsTable table , string FindByColumnName)
        {
            string Code = "";

            Code += FindByColumnName + ",";

            foreach(clsColumn Column in table.Columns)
            {
                if(Column.COLUMN_NAME!=FindByColumnName)
                {
                    Code += $"ref {Column.COLUMN_NAME.ToLower()} ,";
                }
            }

            return Code.TrimEnd(',');
        }
        static private string _Write_VarDecleration_FindBy(clsTable table , string FindByColumnName)
        {
            string Code = "";

            foreach(clsColumn Column in table.Columns)
            {
                if(Column.COLUMN_NAME != FindByColumnName)
                {
                    string DataType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(Column.DATA_TYPE);
                    string DefValue = clsDataManagement.GetDefaultValue(Column.DATA_TYPE);
                    
                    Code += $@"{DataType} {(Column.COLUMN_NAME.ToLower())} = {DefValue};
                                ";
                }
            }

            return Code;
        }
        static public string Write_FindBy(clsTable table,string FindByColumnName)
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
            if (!table.Columns.Any(c => c.COLUMN_NAME == FindByColumnName))
            {
                return "FindBy Code Faild : FindByColumn Name Is Not Existed In Table";
            }
            if (table.Columns.First(c => c.COLUMN_NAME == FindByColumnName).IsNullable)
            {
                return "FindBy Code Faild : This Column Is Nullable";
            }


            string Code = "";
            string FindByColumnType = clsDataManagement.Convert_DataType_From_SQL_To_Csharp(table.Columns.First(c => c.COLUMN_NAME == FindByColumnName).DATA_TYPE);
            string VarDecleration = _Write_VarDecleration_FindBy(table,FindByColumnName);
            string ParametersSend = _Write_ParametersSendTo_Find(table, FindByColumnName);
            string ConstractorsParametersSend = _Write_SendParametersToConstactors_Find(table, FindByColumnName);

            Code = $@"static public cls{table.TableName} FindBy{FindByColumnName}({FindByColumnType} {FindByColumnName})
        {{
            {VarDecleration}

            if (clsData_{table.TableName}.FindBy{FindByColumnName}({ParametersSend}))
            {{
                return new cls{table.TableName}({ConstractorsParametersSend});
            }}
            else
            {{
                return null;
            }}
        }}";

            return Code;
        }


        // Add New Private Method
        static private string _Write_SendVarsToAddNew(clsTable table)
        {
            string Code = "";
            foreach(clsColumn column in table.Columns)
            {
                if(!column.IsPrimaryKey)
                Code += $"{column.COLUMN_NAME},";
            }
            return Code.TrimEnd(',');
        }
        static public string Write_AddNewPrivateMethod(clsTable table)
        {
            string Code = "";
            string PrimaryColumnName = table.Columns.First(c => c.IsPrimaryKey).COLUMN_NAME;
            string SendVarsToAddNew = _Write_SendVarsToAddNew(table);

            Code = $@" private int _AddNew()
        {{
            this.{PrimaryColumnName} =clsData_{table.TableName}.AddNew({SendVarsToAddNew}); 

           return this.{PrimaryColumnName};
        }}";

            return Code;
        }


        // Update Private Method
        static private string _Write_SendVarsToUpdate(clsTable table)
        {
            string Code = "";

            foreach (clsColumn column in table.Columns)
            {
                Code += $"{column.COLUMN_NAME},";
            }
            return Code.TrimEnd(',');
        }
        static public string Write_UpdatePrivateMethod(clsTable table)
        {
            string Code = "";
            string SendVars = _Write_SendVarsToUpdate(table);

            Code = $@" private int _Update()
        {{
            return (clsData_{table.TableName}.Update({SendVars}));
        }}";

            return Code;
        }
            

        // Save Method 
        static public string Write_Save(clsColumn PrimaryKeyColumn)
        {
            string Code = "";

            Code = $@" public bool Save()
        {{
            switch (Mode)
            {{
                case enMode.AddNewMode:
                    
                   if (_AddNew()!=-1)
                   {{
                        this.Mode = enMode.UpdateMode;
                        return true;
                   }}
                   else
                   {{
                        return false;
                   }}
                case enMode.UpdateMode:
                   return _Update()>0;

                default:
                    return false;

            }}
        }}";

            return Code;
        }


        //Final method
        public static string Write_Code(clsTable table)
        {
            string Code = "";

            Code += _Write_Namespaces(table);
            Code += _Write_ClassDefintion(table);

            Code += Write_Properties(table);
            Code += @"

                     ";

            Code += Write_Constractor_Private(table);
            Code += Write_Constractor_Public(table);
            Code += @"

                     ";


            if (table.AddNew && table.Update)
            {
                Code += _Write_Comment("Save");
                Code += Write_Save(table.Columns.First(c=>c.IsPrimaryKey));
                Code += @"


                         ";


                if (table.AddNew)
                {
                    Code += _Write_Comment("Add New");
                    Code += Write_AddNewPrivateMethod(table);
                    Code += @"

                           


                        ";
                }
                if (table.Update)
                {
                    Code += _Write_Comment("Update");
                    Code += Write_UpdatePrivateMethod(table);
                    Code += @"

                           


                        ";
                }
            }
            if (table.ListAll)
            {
                Code += _Write_Comment("List Records");
                Code += Write_ListAllRecords(table);
                Code += @"

                           


                        ";
            }
         
            foreach (clsColumn Column in table.Columns)
            {
                if (Column.Find_By || Column.Delete_By || Column.IsExists_By)
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
                        Code += Write_IsExistsBy(table, Column.COLUMN_NAME);
                        Code += @"

                            ";
                    }

                    Code += @"



                            ";
                }
            }

            Code += _Write_ClosenameSpace();

            return Code;
        }
    }
}
