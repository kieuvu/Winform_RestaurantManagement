using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using RestaurantManagement.Source.Utils;

namespace RestaurantManagement.Source.Repositories
{
    public class UserRepository
    {
        public static DataTable GetUserInfoByUsernameAndPassword(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("@username", username)
                                                     .AddParameter("@password", password);

            return DatabaseHelper.ExecuteQuery(query, parameter);
        }
    }
}