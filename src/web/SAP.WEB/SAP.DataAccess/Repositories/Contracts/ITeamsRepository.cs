#region Using

using SAP.Common.Entities;

#endregion

namespace SAP.DataAccess.Repositories.Contracts
{
    public interface ITeamsRepository
    {
        Team GetById(int id);

        void Save(Team item);

        void Remove(int id);

    }
}
