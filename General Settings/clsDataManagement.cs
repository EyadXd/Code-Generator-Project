using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Settings
{
    static public class clsDataManagement
    {
        private static string ErrorMessag_UnKnowDataType = "This Data Type Is UnKnown In Our Program Pleas Check The Avilable Data Types In Our Guid Or Contact Us";



        private static readonly Dictionary<string, string> SqlToCSharpMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"nvarchar", "string"},//
        {"nchar","string"},//
        {"ntext","string"},//
        {"varchar", "string"},//
        {"char", "string"},//
        {"text", "string"},//
        {"int", "int"},//
        {"bigint", "long"},//
        {"smallint", "short"},//
        {"tinyint", "byte"},//
        {"bit", "bool"},//
        {"decimal", "decimal"},//
        {"numeric", "decimal"},//
        {"float", "double"},//
        {"real", "float"},//
        {"money", "decimal"},//
        {"smallmoney", "decimal"},//
        {"datetime", "DateTime"},//
        {"smalldatetime", "DateTime"},//
        {"datetime2", "DateTime"},//
        {"date", "DateTime"},//
        {"time", "TimeSpan"},//
        {"timestamp", "byte[]"},//
    };
        public static string Convert_DataType_From_SQL_To_Csharp(string sqlDataType)
        {
            if (SqlToCSharpMap.TryGetValue(sqlDataType, out var csharpType))
            {
                return csharpType;
            }
            else
            {
                return ErrorMessag_UnKnowDataType;
            }
        }

        private static readonly Dictionary<string, string> SqlTypeToReaderMethod = new Dictionary<string, string>
    {
        { "int", "GetInt32" },
        { "bigint", "GetInt64" },
        { "smallint", "GetInt16" },
        { "tinyint", "GetByte" },
        { "bit", "GetBoolean" },
        { "decimal", "GetDecimal" },
        { "numeric", "GetDecimal" },
        { "money", "GetDecimal" },
        { "smallmoney", "GetDecimal" },
        { "float", "GetDouble" },
        { "real", "GetFloat" },
        { "char", "GetString" },
        { "varchar", "GetString" },
        { "text", "GetString" },
        { "nchar", "GetString" },
        { "nvarchar", "GetString" },
        { "ntext", "GetString" },
        { "date", "GetDateTime" },
        { "datetime", "GetDateTime" },
        { "datetime2", "GetDateTime" },
        { "smalldatetime", "GetDateTime" },
        { "time", "GetTimeSpan" },
        { "timestamp", "GetBytes" },

    };
        public static string Convert_DataType_To_SqlReaderFunction(string sqlType)
        {
            if (SqlTypeToReaderMethod.TryGetValue(sqlType.ToLower(), out string readerMethod))
            {
                return readerMethod;
            }
            else
            {
                return ErrorMessag_UnKnowDataType;
            }
        }

        private static readonly Dictionary<string, string> SqlTypeToNullValue = new Dictionary<string, string>
    {
        { "int", "0" },
        { "bigint", "0L" },
        { "smallint", "0" },
        { "tinyint", "0" },
        { "bit", "false" },
        { "decimal", "0.0m" },
        { "numeric", "0.0m" },
        { "money", "0.0m" },
        { "smallmoney", "0.0m" },
        { "float", "0.0" },
        { "real", "0.0f" },
        { "char", "\"\"" },
        { "varchar", "\"\"" },
        { "text", "\"\"" },
        { "nchar", "\"\"" },
        { "nvarchar", "\"\"" },
        { "ntext", "\"\"" },
        { "date", "DateTime.MinValue" },
        { "datetime", "DateTime.MinValue" },
        { "datetime2", "DateTime.MinValue" },
        { "smalldatetime", "DateTime.MinValue" },
        { "time", "TimeSpan.Zero" },

    };
        public static string GetNullValue(string sqlType)
        {
            if (SqlTypeToNullValue.TryGetValue(sqlType.ToLower(), out string defaultValue))
            {
                return defaultValue;
            }
            else
            {
                return ErrorMessag_UnKnowDataType;
            }
        }

        private static readonly Dictionary<string, string> SqlTypeToDefault = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "varchar", "string.Empty "},
        { "nvarchar", "string.Empty "},
        { "char", "string.Empty" },
        { "text", "string.Empty" },
        { "int", "-1" },
        { "bigint", "-1L" },
        { "smallint", "(short)-1" },
        { "tinyint", "(byte)0" },
        { "bit", "false" },
        { "float", "-1.0" },
        { "real", "-1.0f" },
        { "decimal", "-1.0m" },
        { "numeric", "-1.0m" },
        { "money", "-1.0m" },
        { "smallmoney", "-1.0m" },
        { "datetime", "DateTime.Now" },
        { "smalldatetime", "DateTime.Now" },
        { "date", "DateTime.Now" },
        { "time", "TimeSpan.Zero" },
    };

        public static string GetDefaultValue(string sqlType)
        {
            if (SqlTypeToDefault.TryGetValue(sqlType.ToLower(), out string defaultValue))
            {
                return defaultValue;
            }
            else
            {
                return ErrorMessag_UnKnowDataType;
            }
        }
    }
}
