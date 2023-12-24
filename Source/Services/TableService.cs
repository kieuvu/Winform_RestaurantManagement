using RestaurantManagement.Source.Repositories;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Services
{
    internal class TableService
    {
        public static int CreateTable(string price, int quantity, int floor)
        {
            int parsedPrice;

            if (string.IsNullOrEmpty(price) || string.IsNullOrWhiteSpace(price))
                throw new Exception("Vui lòng điền giá bàn");
            else if (!int.TryParse(price, out parsedPrice))
                throw new Exception("Vui lòng nhập giá hợp lệ");

            return TableRepository.AddTable(parsedPrice, quantity, floor);
        }

        public static DataTable GetListTables()
        {
            return TableRepository.GetAllTables();
        }

        public static DataTable GetUnbookedTableBetweenDate(string dateFrom, string dateTo)
        {
             return TableRepository.GetUnbookedTableBetweenDate(dateFrom, dateTo);
        }
    }
}
