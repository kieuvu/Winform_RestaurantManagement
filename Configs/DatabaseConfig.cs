using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Configs
{
    internal class DatabaseConfig
    {
        private readonly static string _dataSource = "DESKTOP-8CLBSER\\VUKM";
        private readonly static string _initialCatalog = "QLTS";
        private readonly static bool _integratedSecurity = true;

        public static string GetConnectionString()
        {
            return $"Data Source={_dataSource};"
                 + $"Initial Catalog={_initialCatalog};"
                 + $"Integrated Security={_integratedSecurity};"; ;
        }
    }
}
