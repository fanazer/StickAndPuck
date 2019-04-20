#region Using

using Microsoft.Extensions.DependencyInjection;

#endregion

namespace SAP.API.Dependencies
{
    public class Container
    {
        public Container(IServiceCollection collection)
        {
            new SAP.API.DataAccess.Dependencies(collection);
            new SAP.API.Business.Dependencies(collection);
            new SAP.API.Common.Dependencies(collection);
        }
    }
}
