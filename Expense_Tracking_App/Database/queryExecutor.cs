using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Expense_Tracking_App.Database
{
    internal class queryExecutor : IDisposable
    {
        private IDbConnection _connection;

        public queryExecutor()
        {
            _connection = (new connection()).GetConnection();
        }

        // Executes INSERT, UPDATE, DELETE queries 
        public int ExecuteNonQuery(string query, object parameters = null)
        {
            try
            {
                if (_connection == null)
                {
                    return 0;
                }
                var affectedRows = _connection.Execute(query, parameters);
                Close();
                return affectedRows;

            }
            catch (Exception ex)
            {
                Close();
                throw;
            }
        }

        // Executes SELECT queries 
        public IEnumerable<T> ExecuteSelectQuery<T>(string query, object param = null)
        {
            try
            {
                var results = _connection.Query<T>(query, param);
                Close();
                return results;
            }
            catch (Exception ex)
            {
                Close();
                throw;
            }
        }

        public void Close()
        {

            _connection.Close();

        }

        public void Dispose()
        {

            _connection.Dispose();

        }

    }
}
