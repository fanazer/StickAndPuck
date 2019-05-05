#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.Business.Providers;
using SAP.Business.Providers.Contracts;
using SAP.Business.Providers.People;

#endregion

namespace SAP.Business
{
    public sealed class Dependencies
    {
        public Dependencies(IServiceCollection collection)
        {
            collection.AddTransient<IPlayerProvider, PlayerProvider>();
            collection.AddTransient<ITeamsProvider, TeamProvider>();
        }
    }
}
