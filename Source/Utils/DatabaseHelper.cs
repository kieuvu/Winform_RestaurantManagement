using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using RestaurantManagement.Source.Configs;

namespace RestaurantManagement.Source.Utils
{
    internal class DatabaseHelper
    {
        public static DataTable ExecuteQuery(string sqlQuery, QueryParameter? queryParameter = null)
        {
            using MySqlConnection connection = DatabaseConfig.GetConnection(true);

            using MySqlCommand sqlCommand = new(sqlQuery, connection);

            if (queryParameter != null) sqlCommand.Parameters.AddRange(queryParameter.GetParameter());

            using MySqlDataAdapter adapter = new(sqlCommand);

            DataTable dataTable = new();

            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
