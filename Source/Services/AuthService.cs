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
        public static void Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Vui lòng nhập tên tài khoản và mật khẩu");

            string passwordEncode = new MD5Encoder(password).Encode();

            DataTable rows = UserRepository.GetUserInfoByUsernameAndPassword(username, passwordEncode);

            if (rows.Rows.Count <= 0)
                throw new Exception("Sai tài khoản hoặc mật khẩu");

            DataRow firstRow = rows.Rows[0];

            if (firstRow.Table.Columns.Contains("username"))
                AuthSession.SetUserName(Convert.ToString(firstRow["username"]) ?? "");

            if (firstRow.Table.Columns.Contains("id"))
                AuthSession.SetUserId(Convert.ToInt32(firstRow["id"]));
        }
    }
}
