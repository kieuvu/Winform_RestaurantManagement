using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Drawing;

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

        public static DataTable GetUnbookedTableBetweenDate(string dateFrom, string dateTo)
        {
            string query = "SELECT tables.* FROM tables "
                         + "WHERE id NOT IN (SELECT table_id FROM bookings WHERE booking_from >= @StartDate AND booking_from <= @EndDate)";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("StartDate", DateTime.Parse(dateFrom))
                                                     .AddParameter("EndDate", DateTime.Parse(dateTo));
            
            return DatabaseHelper.ExecuteQuery(query, parameter);
        }
    }
}
