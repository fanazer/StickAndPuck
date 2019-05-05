#region Using

using SAP.Common.Entities.People;
using System.Collections.Generic;

#endregion

namespace SAP.Business.Providers.Contracts
{
    public interface IPlayerProvider
    {
        Player GetById(int id);

        IEnumerable<Player> GetByTop(int quantity);
    }
}
