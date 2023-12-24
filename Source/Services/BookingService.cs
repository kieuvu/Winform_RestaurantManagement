using RestaurantManagement.Source.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Services
{
    internal class BookingService
    {
        public static int CreateBooking(string customerName, string customerPhone, string bookingFrom, string bookingTo, int tableId, int quantity)
        {
            return BookingRepository.AddBooking(customerName, customerPhone, bookingFrom, bookingTo, tableId, quantity);
        }

        public static DataTable GetAllBookings()
        {
            return BookingRepository.GetAllBookings();
        }
    }
}
