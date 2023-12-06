using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public bool IsAdmin { get; set; }
    }
}
