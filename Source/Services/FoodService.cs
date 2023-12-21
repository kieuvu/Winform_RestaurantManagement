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

        public static int CreateFood(string name, string price , int category, int unit)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new Exception("Vui lòng nhập tên thực phẩm");

            int parsedPrice;

            if (string.IsNullOrEmpty(price) || string.IsNullOrWhiteSpace(price))
                throw new Exception("Vui lòng nhập giá");
            else if (!int.TryParse(price, out parsedPrice))
                throw new Exception("Vui lòng nhập giá hợp lệ");

            return FoodRepository.AddFood(name, parsedPrice, category, unit);
        }
    }
}
