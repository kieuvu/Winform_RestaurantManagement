using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Utils
{
    internal class AlertHelper
    {
        public static void Show(string message, string? title = "Vukm")
        {
            MessageBox.Show(message, title);
        }
    }
}
