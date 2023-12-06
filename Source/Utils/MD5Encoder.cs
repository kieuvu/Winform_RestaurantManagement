using RestaurantManagement.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Utils
{
    internal class MD5Encoder : IStringEncoder
    {
        private string ?input;

        public MD5Encoder()
        {
        }

        public MD5Encoder(string input)
        {
            this.input = input;
        }

        public string Encode()
        {
            if (this.input is not null)
            {
                return CalculateMD5Hash(this.input);
            }

            throw new Exception("Can't create hash string from null");
        }

        public void SetEncodeString(string input)
        {
            this.input = input;
        }

        private static string CalculateMD5Hash(string input)
        {
            using MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
