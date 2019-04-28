#region Using

using SAP.Business.Providers.People;
using SAP.Common.Entities;
using SAP.DataAccess.Repositories;
using System;
using System.Collections.Generic;

#endregion

namespace SAP.Business.Providers
{
    internal sealed class TeamProvider : IProvider<Team>
    {
        #region Private Fileds

        private readonly IRepository<Team> _repository;

        #endregion

        #region Constructor

        public TeamProvider(IRepository<Team> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        #endregion

        #region IProvider Implementation

        public IEnumerable<Team> FindBy(Predicate<Team> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _repository.FindBy(predicate);
        }

        public Team Get(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id is not valid", nameof(id));

            return _repository.Get(id);
        }

        #endregion
    }
}
