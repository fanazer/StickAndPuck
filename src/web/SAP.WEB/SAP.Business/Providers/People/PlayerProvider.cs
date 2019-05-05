#region Using

using SAP.Business.Providers.Contracts;
using SAP.Common.Entities.People;
using SAP.DataAccess.Repositories.Contracts;
using System;
using System.Collections.Generic;

#endregion

namespace SAP.Business.Providers.People
{
    internal sealed class PlayerProvider : IPlayerProvider
    {
        #region Private Fileds

        private readonly IPlayersRepository _repository;

        #endregion

        #region Constructor

        public PlayerProvider(IPlayersRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        #endregion

        #region IProvider Implementation

        public Player GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id is not valid", nameof(id));

            return _repository.GetById(id);
        }

        public IEnumerable<Player> GetByTop(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity is not valid", nameof(quantity));

            return _repository.GetByTop(quantity);
        }

        #endregion
    }
}
