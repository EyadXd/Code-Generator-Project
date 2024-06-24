using System;

namespace General_Settings
{
    static public class clsConnectionInfos
    {
        static public string ServerName { get; set; }
        static public string UserID { get; set; }
        static public string Password { get; set; }
        static public string DataBaseName { get; set; }

        static public string ConnectionString()
        {
            if (string.IsNullOrEmpty(ServerName))
                throw new InvalidOperationException("ServerName is not set.");
            if (string.IsNullOrEmpty(UserID))
                throw new InvalidOperationException("UserName is not set.");
            if (string.IsNullOrEmpty(Password))
                throw new InvalidOperationException("Password is not set.");
            if (string.IsNullOrEmpty(DataBaseName))
                throw new InvalidOperationException("DataBaseName is not set.");

            return $"Server={ServerName};User Id={UserID};Password={Password};Database={DataBaseName};";
        }
    }
}