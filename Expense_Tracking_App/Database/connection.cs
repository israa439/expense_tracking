using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracking_App.Database
{
   public class connection : IDisposable
    {
        private  IDbConnection _conn;
        private readonly string connectionString = "Server=ASA\\SQLEXPRESS01;Database=Spendly;User Id=sa;Password=asa1234;";

        public  IDbConnection GetConnection()
        {
            if (_conn == null || _conn.State == ConnectionState.Closed)
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            return _conn;
        }
        public void Close()
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                _conn.Dispose();
            }
        }
    }
}
