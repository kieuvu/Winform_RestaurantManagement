using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
            string query = "INSERT INTO tables (`price`, `quantity`, `floor`) "
                         + "VALUES (@price, @quantity, @floor)";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("price", price)
                                                     .AddParameter("quantity", quantity)
                                                     .AddParameter("floor", floor);

            return DatabaseHelper.ExecuteNonQuery(query, parameter);
        }
    }
}
