using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Writer
{
    static public class clsCodeWriter_AdditionalClasses
    {

        //Connection String
        public static string Write_ConnectionStringClass(string ConnectionString,string DataAccessNameSpace)
        {
            string Code = $@"using System;

            namespace {DataAccessNameSpace}
              {{
             static class clsConnectionString
              {{
             public static string ConnectionString = ""{ConnectionString}"";


              }}
              }}  ";

            return Code;
        }
    }
}
