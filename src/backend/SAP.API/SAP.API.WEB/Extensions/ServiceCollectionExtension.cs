#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.API.Dependencies;

#endregion

namespace SAP.API.WEB.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection source)
        {
            new Container(source);
            return source;
        }
    }
}
