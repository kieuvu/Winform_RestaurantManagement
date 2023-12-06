using MySql.Data.MySqlClient;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Services
{
    internal class AuthService
    {
        public static string Login(string username, string password)
        {
            string passwordEncode = new MD5Encoder(password).Encode();

            MySqlDataReader reader = DatabaseUtils.ExecuteSqlQuery(
                "SELECT * FROM users WHERE username = @username AND password = @password",
                new []
                {
                    new MySqlParameter("@username", username),
                    new MySqlParameter("@password", passwordEncode),
                });

            string rd_username = "EMPTY";

            while (reader.Read())
            {
                rd_username = reader["username"] is not null ? reader["username"].ToString() : rd_username;
            }

            return rd_username;
        }
    }
}
