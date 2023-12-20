using RestaurantManagement.Source.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Services
{
    internal class FoodService
    {
        public static DataTable GetListFoods()
        {
            return FoodRepository.GetAllFoods();
        }

        public static DataTable GetListUnit()
        {
            return FoodRepository.GetAllUnit();
        }

        public static DataTable GetListCategory()
        {
            return FoodRepository.GetAllCategory();
        }
    }
}
