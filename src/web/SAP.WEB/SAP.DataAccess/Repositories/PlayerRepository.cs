#region Using

using SAP.Common.Entities.People;
using SAP.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using SAP.DataAccess.Repositories.Contracts;

#endregion

namespace SAP.DataAccess.Repositories
{
    internal sealed class PlayersesRepository : IPlayersRepository
    {
        #region Private Fileds

        private readonly IDbContextFactory _dbContextFactory;

        #endregion

        #region Constructor

        public PlayersesRepository(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        #endregion

        #region IRepository Implementation

        public Player GetById(int id)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                return dbContext.Query<Player>("SelectPlayerById", new { Id = id }).First();
            }
        }
        public IEnumerable<Player> GetByTop(int quantity)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                return dbContext.Query<Player>("SelectPlayersByTop", new { Quantity = quantity }).ToList();
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
