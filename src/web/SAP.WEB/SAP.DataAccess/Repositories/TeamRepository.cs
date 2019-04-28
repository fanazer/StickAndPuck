#region Using

using SAP.Common.Entities;
using SAP.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace SAP.DataAccess.Repositories
{
    internal sealed class TeamsRepository : IRepository<Team>
    {
        #region Private Fileds

        private readonly IDbContextFactory _dbContextFactory;

        #endregion

        #region Constructor

        public TeamsRepository(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        #endregion

        #region IRepository Implementation

        public IEnumerable<Team> FindBy(Predicate<Team> predicate)
        {
            throw new NotImplementedException();
        }

        public Team Get(int id)
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
