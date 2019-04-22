#region Using

using System;
using Microsoft.Extensions.Configuration;

#endregion

namespace SAP.API.DataAccess.DbContext
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
