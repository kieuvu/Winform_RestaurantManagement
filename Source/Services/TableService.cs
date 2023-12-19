using RestaurantManagement.Source.Repositories;
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
        public static int CreateTable(int price, int quantity ,int floor)
        {
            return TableRepository.AddTable(price, quantity, floor);
        }

        public static DataTable GetListTables()
        {
            return TableRepository.GetAllTables();
        }
    }
}
