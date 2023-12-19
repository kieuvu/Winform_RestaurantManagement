using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Utils
{
    internal class StringHelper
    {
        public static string PadNumberWithZeros(object number, int totalWidth = 6)
        {
            if (number is string stringValue)
            {
                if (int.TryParse(stringValue, out int intValue))
                {
                    return intValue.ToString().PadLeft(totalWidth, '0');
                }
                else
                {
                    throw new ArgumentException("Invalid string input. Must be a numeric string.", nameof(number));
                }
            }
            else if (number is int intValue)
            {
                return intValue.ToString().PadLeft(totalWidth, '0');
            }
            else
            {
                throw new ArgumentException("Invalid input type. Must be either a numeric string or an integer.", nameof(number));
            }
        }
    }
}
