using RestaurantManagement.Source.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace RestaurantManagement.Source.Services
{
    internal class StaffService
    {
        public static DataTable GetListStaffPosition()
        {
            return StaffRepository.GetAllStaffPostions();
        }

        public static DataTable GetListStaffs()
        {
            return StaffRepository.GetAllStaffs();
        }

        public static int CreateStaff(string name, int gender, string dob, 
                                      string joinDate, string email, string phone, 
                                      string address, int position, string salary)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new Exception("Vui lòng nhập tên nhân viên");

            if (string.IsNullOrEmpty(phone) || string.IsNullOrWhiteSpace(phone))
                throw new Exception("Vui lòng nhập số điện thoại");

            if (string.IsNullOrEmpty(address) || string.IsNullOrWhiteSpace(address))
                throw new Exception("Vui lòng nhập địa chỉ");

            int parsedSalary;

            if (string.IsNullOrEmpty(salary) || string.IsNullOrWhiteSpace(salary))
                throw new Exception("Vui lòng nhập lương");
            else if (!int.TryParse(salary, out parsedSalary))
                throw new Exception("Vui lòng nhập lương hợp lệ");

            return StaffRepository.AddStaff(name, gender, dob, 
                                            joinDate, email, phone, 
                                            address, position, parsedSalary);
        }

        public static int DeleteStaffById(int staffId)
        {
            return StaffRepository.DeleteStaffById(staffId);
        }
    }
}
