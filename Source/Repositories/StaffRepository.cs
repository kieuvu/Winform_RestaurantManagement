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
using System.Reflection;
using System.Net.NetworkInformation;

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

        public static int AddStaff(string name, int gender, string dob,
                                   string joinDate, string email, string phone,
                                   string address, int position, int salary)
        {
            string query = "INSERT INTO staffs (`name`, `dob`, `gender`, `position_id`, `salary`, `join_date`, `phone`, `address`, `email`) "
                         + "VALUES (@name, @dob, @gender, @position, @salary, @joinDate, @phone, @address, @email)";

            QueryParameter parameter = QueryParameter.Builder()
                                                     .AddParameter("name", name)
                                                     .AddParameter("gender", gender)
                                                     .AddParameter("dob", dob)
                                                     .AddParameter("joinDate", joinDate)
                                                     .AddParameter("email", email)
                                                     .AddParameter("phone", phone)
                                                     .AddParameter("address", address)
                                                     .AddParameter("position", position)
                                                     .AddParameter("salary", salary);

            return DatabaseHelper.ExecuteNonQuery(query, parameter);
        }

        public static int DeleteStaffById(int id)
        {
            string query = "DELETE FROM `staffs` WHERE `staffs`.`id` = @id";

            QueryParameter parameter = QueryParameter.Builder().AddParameter("id", id);

            return DatabaseHelper.ExecuteNonQuery(query, parameter);
        }

        public static DataTable GetStaffById(int staffId)
        {
            string query = "SELECT id, name, position_id FROM staffs WHERE id = @id";

            QueryParameter parameter = QueryParameter.Builder().AddParameter("id", staffId);

            return DatabaseHelper.ExecuteQuery(query, parameter);
        }
    }
}
