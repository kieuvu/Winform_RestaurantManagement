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
    internal class DatabaseUtils
    {
        public static MySqlDataReader ExecuteSqlQuery(string sqlQuery, MySqlParameter[] parameters = null)
        {
            using MySqlConnection connection = DatabaseConfig.GetConnection();
            connection.Open();

            using MySqlCommand sqlCommand = new(sqlQuery, connection);
            if (parameters != null)
            {
                sqlCommand.Parameters.AddRange(parameters);
            }

            return sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
