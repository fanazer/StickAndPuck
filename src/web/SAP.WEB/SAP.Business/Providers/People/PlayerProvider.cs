#region Using

using SAP.Common.Entities.People;
using SAP.DataAccess.Repositories;
using System;
using System.Collections.Generic;

#endregion

namespace SAP.Business.Providers.People
{
    internal sealed class PlayerProvider : IProvider<Player>
    {
        #region Private Fileds

        private readonly IRepository<Player> _repository;

        #endregion

        #region Constructor

        public PlayerProvider(IRepository<Player> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        #endregion

        #region IProvider Implementation

        public IEnumerable<Player> FindBy(Predicate<Player> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _repository.FindBy(predicate);
        }

        public Player Get(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id is not valid", nameof(id));
            }
            return _repository.Get(id);
        }

        #endregion
    }
}
