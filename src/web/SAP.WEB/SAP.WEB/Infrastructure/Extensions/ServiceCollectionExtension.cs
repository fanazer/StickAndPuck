#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.Dependencies;

#endregion

namespace SAP.WEB.Extensions
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
