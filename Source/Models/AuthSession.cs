using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Models
{
    internal class AuthSession
    {
        public static readonly int ADMIN = 1;
        public static readonly int STAFF = 2;

        public static int Id { get; private set; } = 0;
        public static string Username { get; private set; } = "";
        public static int Role { get; private set; } = AuthSession.ADMIN;

        public static bool IsAdmin()
        {
            return Role == AuthSession.ADMIN;
        }

        public static bool IsStaff()
        {
            return Role == AuthSession.STAFF;
        }

        public static void SetUserName(string username)
        {
            Username = username;
        }

        public static void SetUserId(int id)
        {
            Id = id;
        }

        public static void SetRole(int role)
        {
            Role = role;
        }
    }
}
