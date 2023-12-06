using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Interfaces
{
    internal interface IStringEncoder
    {
        string Encode();
        void SetEncodeString(string input);
    }
}
