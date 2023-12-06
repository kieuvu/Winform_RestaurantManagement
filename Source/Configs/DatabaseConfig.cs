using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Configs
{
    internal class DatabaseConfig
    {
        private readonly static string _serverName = "localhost";
        private readonly static string _databaseName = "winform_app";
        private readonly static string _username = "root";
        private readonly static string _password = "";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new(GetConnectionString());
            return connection;
        }

        private static string GetConnectionString()
        {
            return $"Server={_serverName}"
                 + $"Database={_databaseName}"
                 + $"User ID={_username}"
                 + $"Password={_password};";
        }
    }
}
