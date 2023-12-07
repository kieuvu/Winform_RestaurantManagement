using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Utils
{
    internal class QueryParameter
    {
        private readonly Dictionary<string, object> _parameters;

        public QueryParameter()
        {
            this._parameters = new Dictionary<string, object>();
        }

        public static QueryParameter Builder() {
            return new QueryParameter();
        }

        public QueryParameter AddParameter(string key, string value)
        {
            this._parameters.Add(key, value);
            return this;
        }

        public Dictionary<string, object> GetParameter()
        {
            return this._parameters;
        }
    }
}
