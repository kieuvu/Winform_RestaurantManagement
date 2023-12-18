using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Models
{
    internal class AuthSession
    {
        public static int Id { get; private set; } = 0;
        public static string Username { get; private set; } = "";

        public static void SetUserName(string username)
        {
            Username = username;
        }

        public static void SetUserId(int id)
        {
            Id = id;
        }
    }
}
