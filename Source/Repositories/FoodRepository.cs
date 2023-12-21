using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Repositories
{
    internal class FoodRepository
    {
        public static DataTable GetAllFoods()
        {
            string query = "SELECT foods.*, food_categories.name AS category_name, food_units.name AS unit_name "
                         + "FROM foods " 
                         + "INNER JOIN food_categories "
                         + "ON foods.category_id = food_categories.id "
                         + "INNER JOIN food_units "
                         + "ON foods.unit_id = food_units.id";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetAllCategory()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM food_categories");
        }

        public static DataTable GetAllUnit()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM food_units");
        }

        public static int AddFood(string name, int price, int category, int unit) 
        {
            string query = "INSERT INTO foods (`name`, `price`, `category_id`, `unit_id`) "
                         + "VALUES (@name, @price, @category, @unit)";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("name", name)
                                                     .AddParameter("price", price)
                                                     .AddParameter("category", category)
                                                     .AddParameter("unit", unit);

            return DatabaseHelper.ExecuteNonQuery(query, parameter);
        }
    }
}
