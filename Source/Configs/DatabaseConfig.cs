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
        private readonly static string _serverName = "127.0.0.1";
        private readonly static string _databaseName = "winform_app";
        private readonly static string _username = "root";
        private readonly static string _password = "";
        private readonly static int _port = 3306;

        public static MySqlConnection GetConnection(bool forceOpen = false)
        {
            MySqlConnection connection = new(GetConnectionString());

            if (forceOpen) connection.Open();

            return connection;
        }

        private static string GetConnectionString()
        {
            return $"Server={_serverName};"
                 + $"Database={_databaseName};"
                 + $"Port={_port};"
                 + $"Uid={_username};"
                 + $"Pwd={_password};";
        }
    }
}
