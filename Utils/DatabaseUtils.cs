using RestaurantManagement.Configs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantManagement.Utils
{
    internal class DatabaseUtils
    {
        private static readonly string _connectString = DatabaseConfig.GetConnectionString();

        public static SqlDataReader ExecuteSqlQuery(string sqlQuery, SqlParameter[]? parameters = null)
        {
            SqlConnection connection = new(_connectString);
            connection.Open();

            using (SqlCommand sqlCommand = new(sqlQuery, connection))
            {
                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                return sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    }
}
