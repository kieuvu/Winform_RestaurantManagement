using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantManagement.Source.Utils;

namespace Winform_RestaurantManagement.Source.Repositories
{
    public class UserRepository
    {
        public static DataTable GetUserInfoByUsernameAndPassword(string username, string password) 
        {   
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("@username", username)
                                                     .AddParameter("@password", password);

            return DatabaseUtils.ExecuteQuery(query, parameter);
        } 
    }
}