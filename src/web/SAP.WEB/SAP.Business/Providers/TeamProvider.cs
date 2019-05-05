#region Using

using SAP.Business.Providers.People;
using SAP.Common.Entities;
using SAP.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using SAP.Business.Providers.Contracts;
using SAP.DataAccess.Repositories.Contracts;

#endregion

namespace SAP.Business.Providers
{
    internal sealed class TeamProvider : ITeamsProvider
    {
        #region Private Fileds

        private readonly ITeamsRepository _repository;

        #endregion

        #region Constructor

        public TeamProvider(ITeamsRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        #endregion

        #region IProvider Implementation

        public Team GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id is not valid", nameof(id));

            return _repository.GetById(id);
        }

        #endregion
    }
}
