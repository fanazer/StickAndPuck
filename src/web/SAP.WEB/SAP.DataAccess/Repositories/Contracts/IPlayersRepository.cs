#region Using

using SAP.Common.Entities.People;
using System.Collections.Generic;

#endregion

namespace SAP.DataAccess.Repositories.Contracts
{
    public interface IPlayersRepository
    {
        Player GetById(int id);

        IEnumerable<Player> GetByTop(int quantity);

        void Remove(int id);

        void Save(Player item);
    }
}
