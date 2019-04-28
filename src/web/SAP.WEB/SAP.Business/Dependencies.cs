#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.Business.Providers;
using SAP.Business.Providers.People;
using SAP.Common.Entities;
using SAP.Common.Entities.People;

#endregion

namespace SAP.Business
{
    public sealed class Dependencies
    {
        public Dependencies(IServiceCollection collection)
        {
            collection.AddTransient<IProvider<Player>, PlayerProvider>();
            collection.AddTransient<IProvider<Team>, TeamProvider>();
        }
    }
}
