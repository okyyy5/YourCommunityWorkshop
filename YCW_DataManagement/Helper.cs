using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCW_DataManagement
{
    public static class Helper
    {
        // Retrieves connection strings from App.config file
        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static SqlConnection CreateDatabaseConnection()
        {
            return new SqlConnection(GetConnectionString("Workshop"));
        }
    }
}
