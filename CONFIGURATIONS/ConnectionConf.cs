using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace ThinkCE_Store_Management_System.CONFIGURATIONS
{
    internal class ConnectionConf
    {
        private static string MainConnection()
        {
            return ConfigurationManager.ConnectionStrings["main_connection"].ConnectionString;
        }

        public MySqlConnection Maincon() { return new MySqlConnection(MainConnection()); }
        private static string SqliteConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        }
        public MySqlConnection LocalDBCon() { return new MySqlConnection(SqliteConnectionString()); } 
    }
}
