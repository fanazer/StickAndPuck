#region Using

using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

#endregion

namespace SAP.DataAccess.DbContext
{
    internal sealed class DbContext : IDbContext
    {
        #region Private Fields

        private readonly SqlConnection _connection;

        #endregion

        #region Constructor

        public DbContext(string dbConnectionString)
        {
            _connection = new SqlConnection(dbConnectionString);
        }

        #endregion

        #region DbContext Implementation

        public IEnumerable<T> Query<T>(string procedureName, object parameters)
        {
            return _connection.Query<T>(procedureName, parameters, commandType: CommandType.StoredProcedure).ToList();
        }

        #endregion

        #region Dispose


        public void Dispose()
        {
            if ((_connection.State & ConnectionState.Open) != 0)
            {
                _connection.Close();
            }
        }

        #endregion
    }
}
