using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class BaseConnection
    {
        public IDbConnection getConnection()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["Colegio"].ConnectionString;
            return new SqlConnection(strConnection);
        }
    }
}

