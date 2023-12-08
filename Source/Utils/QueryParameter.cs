using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Source.Utils
{
    internal class QueryParameter
    {
        private readonly List<MySqlParameter> _parameters;

        public QueryParameter()
        {
            this._parameters = new List<MySqlParameter>();
        }

        public static QueryParameter Builder() 
        {
            return new QueryParameter();
        }

        public QueryParameter AddParameter(string key, string value)
        {
            this._parameters.Add(new MySqlParameter("@" + key, value));
            return this;
        }

        public MySqlParameter[] GetParameter()
        {
            return this._parameters.ToArray<MySqlParameter>();
        }
    }
}
