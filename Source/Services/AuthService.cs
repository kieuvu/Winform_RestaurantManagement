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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestaurantManagement.Source.Services
{
    internal class AuthService
    {
        public static int LoginStaff(string staffId)
        {
            if (string.IsNullOrWhiteSpace(staffId) || string.IsNullOrEmpty(staffId))
                throw new Exception("Vui lòng nhập tên tài khoản");
            else if (staffId.Length != 6)
                throw new Exception("Vui lòng nhập tên tài khoản gồm 6 ký tự");

            DataTable rows = StaffRepository.GetStaffById(Convert.ToInt32(staffId));

            if (rows.Rows.Count <= 0)
                throw new Exception($"Nhân viên {staffId} không tồn tại");

            DataRow firstRow = rows.Rows[0];

            AuthSession.SetUserName(Convert.ToString(firstRow["name"]) ?? "");
            AuthSession.SetUserId(Convert.ToInt32(firstRow["id"]));
            AuthSession.SetRole(AuthSession.STAFF);

            return 1;
        }

        public static void LoginAdmin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Vui lòng nhập tên tài khoản và mật khẩu");

            string passwordEncode = new MD5Encoder(password).Encode();

            DataTable rows = UserRepository.GetUserInfoByUsernameAndPassword(username, passwordEncode);

            if (rows.Rows.Count <= 0)
                throw new Exception("Sai tài khoản hoặc mật khẩu");

            DataRow firstRow = rows.Rows[0];

            AuthSession.SetUserName(Convert.ToString(firstRow["username"]) ?? "");
            AuthSession.SetUserId(Convert.ToInt32(firstRow["id"]));
            AuthSession.SetRole(AuthSession.ADMIN);
        }
    }
}
