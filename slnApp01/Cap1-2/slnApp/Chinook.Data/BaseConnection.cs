using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class BaseConnection
    {
        public IDbConnection getConnection() {
            string strConnection = ConfigurationManager.ConnectionStrings["Chinook"].ConnectionString;
            return new SqlConnection(strConnection);
        }
    }
}
