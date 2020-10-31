using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class CustomerDA : BaseConnection
    {
        public DataTable GetCustomer()
        {
            var da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "Select * from Customer(NOLOCK)";
            da.SelectCommand.Connection = (SqlConnection)getConnection();

            var dataTable = new DataTable();
            da.Fill(dataTable);

            return dataTable;
        }
    }
}
