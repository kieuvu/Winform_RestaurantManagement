using MySql.Data.MySqlClient;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RestaurantManagement.Source.Models;
using RestaurantManagement.Source.Repositories;

namespace RestaurantManagement.Source.Services
{
    internal class AuthService
    {
        public static string Login(string username, string password)
        {
            string passwordEncode = new MD5Encoder(password).Encode();

            DataTable rows = UserRepository.GetUserInfoByUsernameAndPassword(username, passwordEncode);

            if (rows.Rows.Count <= 0)
                throw new Exception("Sai tên đăng nhập hoặc mật khẩu");

            DataRow firstRow = rows.Rows[0];

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
}
