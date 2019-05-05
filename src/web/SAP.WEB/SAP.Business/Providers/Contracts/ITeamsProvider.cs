#region Using

using SAP.Common.Entities;

#endregion

namespace SAP.Business.Providers.Contracts
{
    public interface ITeamsProvider
    {
        Team GetById(int id);

    }
}
