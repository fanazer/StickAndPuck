#region Using

using SAP.Common.Entities;
using SAP.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using SAP.DataAccess.Repositories.Contracts;

#endregion

namespace SAP.DataAccess.Repositories
{
    internal sealed class TeamsesRepository : ITeamsRepository
    {
        #region Private Fileds

        private readonly IDbContextFactory _dbContextFactory;

        #endregion

        #region Constructor

        public TeamsesRepository(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        #endregion

        #region IRepository Implementation

        public Team GetById(int id)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                return dbContext.Query<Team>("SelectTeamById", new { Id = id }).First();
            }
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Team item)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
