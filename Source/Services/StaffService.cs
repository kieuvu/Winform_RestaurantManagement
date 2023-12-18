using RestaurantManagement.Source.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static bool AddStaff()
        {
            return true;
        }
    }
}
