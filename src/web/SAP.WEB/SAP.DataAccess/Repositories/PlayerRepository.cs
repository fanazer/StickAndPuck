#region Using

using SAP.Common.Entities.People;
using SAP.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace SAP.DataAccess.Repositories
{
    internal sealed class PlayersRepository : IRepository<Player>
    {
        #region Private Fileds

        private readonly IDbContextFactory _dbContextFactory;

        #endregion

        #region Constructor

        public PlayersRepository(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        #endregion

        #region IRepository Implementation

        public IEnumerable<Player> FindBy(Predicate<Player> predicate)
        {
            return null;
        }

        public Player Get(int id)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                return dbContext.Query<Player>("SelectPlayerById", new { Id = id }).First();
            }
        }

        public void Remove(int id)
        {
        }

        public void Save(Player item)
        {
        }

        #endregion
    }
}
