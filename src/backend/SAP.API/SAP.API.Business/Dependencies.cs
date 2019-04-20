#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.API.Business.Providers;
using SAP.API.Business.Providers.People;
using SAP.API.Common.Entities.People;

#endregion

namespace SAP.API.Business
{
    public sealed class Dependencies
    {
        public Dependencies(IServiceCollection collection)
        {
            collection.AddTransient<IProvider<Player>, PlayerProvider>();
        }
    }
}
