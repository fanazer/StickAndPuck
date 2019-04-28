#region Using

using Microsoft.Extensions.Configuration;
using System;

#endregion

namespace SAP.DataAccess.DbContext
{
    internal sealed class DbContextFactory : IDbContextFactory
    {

        #region Private Fileds

        private string _connectionString;

        #endregion

        #region Constructor

        public DbContextFactory(IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        #endregion

        #region DbContextFactory Implementation

        public IDbContext Create()
        {
            return new DbContext(_connectionString);
        }

        #endregion

    }
}
