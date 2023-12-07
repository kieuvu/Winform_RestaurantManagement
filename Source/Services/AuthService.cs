using MySql.Data.MySqlClient;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RestaurantManagement.Source.Models;

namespace RestaurantManagement.Source.Services
{
    internal class AuthService
    {
        public static string Login(string username, string password)
        {
            string passwordEncode = new MD5Encoder(password).Encode();

            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("@username", username)
                                                     .AddParameter("@password", passwordEncode);

            DataTable rows = DatabaseUtils.ExecuteQuery(query, parameter);

            if (rows.Rows.Count > 0)
            {
                DataRow firstRow = rows.Rows[0];

                if (firstRow != null)
                {
                    User user = new();

                    if (firstRow.Table.Columns.Contains("username")) 
                        user.Username = Convert.ToString(firstRow["username"]);

                    if (firstRow.Table.Columns.Contains("id")) 
                        user.Id = Convert.ToInt32(firstRow["id"]);

                    if (firstRow.Table.Columns.Contains("is_admin"))
                        user.IsAdmin = Convert.ToBoolean(firstRow["is_admin"]);

                    return "Success";
                }
            }

            return "User Not Found";
        }
    }
}
