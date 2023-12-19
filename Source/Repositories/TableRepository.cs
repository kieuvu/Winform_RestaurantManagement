using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Repositories
{
    internal class TableRepository
    {
        public static DataTable GetAllTables()
        {
            string query = "SELECT * FROM tables";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public static int AddTable(int price, int quantity, int floor)
        {
            return 1;
        }
    }
}
