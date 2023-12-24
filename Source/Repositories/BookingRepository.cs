using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using RestaurantManagement.Source.Forms.Booking;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Repositories
{
    internal class BookingRepository
    {
        public static int AddBooking (string customerName,string customerPhone, string bookingFrom, string bookingTo, int tableId, int quantity)
        {
            string query = "INSERT INTO `bookings` (`customer_name`, `customer_phone`, `booking_from`, `booking_to`, `table_id`, `quantity`) "
                         + "VALUES (@name, @phone, @from, @to, @tableId, @quantity)";

            QueryParameter parameters = QueryParameter.Builder()
                                                      .AddParameter("name", customerName)
                                                      .AddParameter("phone", customerPhone)
                                                      .AddParameter("from", bookingFrom)
                                                      .AddParameter("to", bookingTo)
                                                      .AddParameter("tableId", tableId)
                                                      .AddParameter("quantity", quantity);

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static DataTable GetAllBookings()
        {
            string query = "SELECT bookings.customer_name, bookings.customer_phone, bookings.booking_from, bookings.booking_to, bookings.quantity, tables.id AS table_id, tables.floor FROM bookings JOIN tables ON bookings.table_id = tables.id";

            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
