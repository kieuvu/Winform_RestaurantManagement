using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestaurantManagement.Source.Repositories
{
    internal class StaffRepository
    {
        public static DataTable GetAllStaffPostions()
        {
            string query = "SELECT * FROM positions";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetAllStaffs()
        {
            string query = "SELECT staffs.*, positions.name AS position_name "
                         + "FROM staffs INNER JOIN positions "
            + "ON staffs.position_id = positions.id";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static bool AddStaff()
        {
            string query = "INSERT INTO staffs (`name`, `dob`, `gender`, `position_id`, `salary`, `join_date`, `phone`, `address`, `email`) "
                         + "VALUES (@name, @dob, @gender, @position, @salary, @joinDate, @phone, @address, @email)";

           // QueryParameter parameter = QueryParameter.Builder()
             //                                        .AddParameter("username", username)
               //                                      .AddParameter("password", password);
            return true;
        }
    }
}
