using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General_Settings;
using System.Data.SqlClient;
using System.Data;

namespace Tables_Data_Layer
{
    static public class TableDataAccess
    {
        static public DataTable GetTablesNames()
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionInfos.ConnectionString()))
            {
                string query = $@"USE {clsConnectionInfos.DataBaseName}
                          SELECT table_name AS TableName
                          FROM information_schema.tables
                          WHERE table_type = 'BASE TABLE'
                              AND table_name <> 'sysdiagrams'
                          ORDER BY table_name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                    }
                    catch 
                    {

                    }
            

                    return table;
                }
            }
        }
        static public bool IsExists(string TableName)
        {
            SqlConnection connection = new SqlConnection(clsConnectionInfos.ConnectionString());

            string Querey = $@"Use {clsConnectionInfos.DataBaseName}
                              SELECT 1
                              FROM information_schema.tables
                              WHERE TABLE_CATALOG = @DataBaseName
                                  AND table_type = 'BASE TABLE'
                              	AND table_name <> 'sysdiagrams'
                              	AND table_name = @TableName
                              ";

            SqlCommand command = new SqlCommand(Querey, connection);
            command.Parameters.AddWithValue("@DataBaseName", clsConnectionInfos.DataBaseName);
            command.Parameters.AddWithValue("@TableName", TableName);

            bool IsFound = false;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsFound = result == null ? false : true;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
    }

    static public class ColumnDataAccess
    {

        static public DataTable GetColumnsNames(string TableName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionInfos.ConnectionString()))
            {
                string query = $@"
            Use {clsConnectionInfos.DataBaseName}
            SELECT 
                c.COLUMN_NAME
            FROM 
                INFORMATION_SCHEMA.COLUMNS c
            LEFT JOIN 
                (
                    SELECT 
                        ku.TABLE_SCHEMA,
                        ku.TABLE_NAME,
                        ku.COLUMN_NAME
                    FROM 
                        INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
                    INNER JOIN 
                        INFORMATION_SCHEMA.KEY_COLUMN_USAGE ku
                    ON 
                        tc.TABLE_NAME = ku.TABLE_NAME
                        AND tc.TABLE_SCHEMA = ku.TABLE_SCHEMA
                        AND tc.CONSTRAINT_NAME = ku.CONSTRAINT_NAME
                    WHERE 
                        tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
                ) pk
            ON 
                c.TABLE_SCHEMA = pk.TABLE_SCHEMA
                AND c.TABLE_NAME = pk.TABLE_NAME
                AND c.COLUMN_NAME = pk.COLUMN_NAME
            WHERE 
                c.TABLE_NAME = @TableName
            ORDER BY 
                ORDINAL_POSITION;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TableName", TableName);

                    DataTable table = new DataTable();

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        table.Load(reader); // Load all rows into DataTable directly
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                    return table;
                }
            }
        }

        static public bool IsExists(string TableName,string ColumnName)
        {
            SqlConnection connection = new SqlConnection(clsConnectionInfos.ConnectionString());

            string Querey = $@"Use {clsConnectionInfos.DataBaseName}
                           	Select 
                               1              
                           FROM 
                               INFORMATION_SCHEMA.COLUMNS c
                           LEFT JOIN 
                               (
                                   SELECT 
                                       ku.TABLE_SCHEMA,
                                       ku.TABLE_NAME,
                                       ku.COLUMN_NAME
                                   FROM 
                                       INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
                                   INNER JOIN 
                                       INFORMATION_SCHEMA.KEY_COLUMN_USAGE ku
                                   ON 
                                       tc.TABLE_NAME = ku.TABLE_NAME
                                       AND tc.TABLE_SCHEMA = ku.TABLE_SCHEMA
                                       AND tc.CONSTRAINT_NAME = ku.CONSTRAINT_NAME
                                   WHERE 
                                       tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
									     
                               ) pk
                           ON 
                               c.TABLE_SCHEMA = pk.TABLE_SCHEMA
                               AND c.TABLE_NAME = pk.TABLE_NAME
                               AND c.COLUMN_NAME = pk.COLUMN_NAME
                           WHERE 
                               c.TABLE_NAME = @TableName	
						    AND c.COLUMN_NAME = @ColumnName
							    	
                           ORDER BY 
                               ORDINAL_POSITION ;
                              ";

            SqlCommand command = new SqlCommand(Querey, connection);
            command.Parameters.AddWithValue("@ColumnName", ColumnName);
            command.Parameters.AddWithValue("@TableName", TableName);

            bool IsFound = false;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsFound = result == null ? false : true;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public DataTable ListColumns(string TableName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionInfos.ConnectionString()))
            {
                string query = $@"
                    SELECT 
                        c.COLUMN_NAME,
                        c.DATA_TYPE,
                        c.CHARACTER_MAXIMUM_LENGTH,
                        CASE 
                            WHEN c.IS_NULLABLE = 'YES' THEN 1 
                            ELSE 0 
                        END AS IsNullable,
                        COLUMNPROPERTY(OBJECT_ID(c.TABLE_SCHEMA + '.' + c.TABLE_NAME), c.COLUMN_NAME, 'IsIdentity') AS IsIdentity,
                        CASE 
                            WHEN pk.COLUMN_NAME IS NOT NULL THEN 1 
                            ELSE 0 
                        END AS IsPrimaryKey
                    FROM 
                        {clsConnectionInfos.DataBaseName}.INFORMATION_SCHEMA.COLUMNS c
                    LEFT JOIN 
                        (
                            SELECT 
                                ku.TABLE_SCHEMA,
                                ku.TABLE_NAME,
                                ku.COLUMN_NAME
                            FROM 
                                {clsConnectionInfos.DataBaseName}.INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
                            INNER JOIN 
                                {clsConnectionInfos.DataBaseName}.INFORMATION_SCHEMA.KEY_COLUMN_USAGE ku
                            ON 
                                tc.TABLE_NAME = ku.TABLE_NAME
                                AND tc.TABLE_SCHEMA = ku.TABLE_SCHEMA
                                AND tc.CONSTRAINT_NAME = ku.CONSTRAINT_NAME
                            WHERE 
                                tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
                        ) pk
                    ON 
                        c.TABLE_SCHEMA = pk.TABLE_SCHEMA
                        AND c.TABLE_NAME = pk.TABLE_NAME
                        AND c.COLUMN_NAME = pk.COLUMN_NAME
                    WHERE 
                        c.TABLE_NAME = @TableName
                    ORDER BY 
                        IsPrimaryKey DESC;";

                SqlCommand command = new SqlCommand(query, connection);
               
                    command.Parameters.AddWithValue("@TableName", TableName);

                    DataTable table = new DataTable();

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        table.Load(reader);                
                    }
                    catch 
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return table;
                
            }
        }
    }

    static public class DataBaseDataAccess
    {
        static public DataTable GetDataBaseName()
        {
            string connectionString = $"Server={clsConnectionInfos.ServerName};User Id={clsConnectionInfos.UserID};Password={clsConnectionInfos.Password};Database=master;";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT name 
                        FROM sys.databases 
                        WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch
            {

            }
            return dt;
        }

        static public bool IsExists(string dataBaseName)
        {
            string connectionString = $"Server={clsConnectionInfos.ServerName};User Id={clsConnectionInfos.UserID};Password={clsConnectionInfos.Password};Database=master;";

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 1 
                        FROM sys.databases 
                        WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb') And name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", dataBaseName);

                        IsFound = command.ExecuteScalar() == null ? false : true;
                    }
                }
            }
            catch
            {

            }
            return IsFound;
        }

        static public bool DeleteDataBase(string DatabaseName)
        {

            string connectionString = $"Server={clsConnectionInfos.ServerName};User Id={clsConnectionInfos.UserID};Password={clsConnectionInfos.Password};Database=master;";

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    DROP DATABASE @Name;
                                   ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", DatabaseName);

                        IsFound = command.ExecuteNonQuery() != 0 ? false : true;
                    }
                }
            }
            catch
            {

            }
            return IsFound;

        }
    }
}
