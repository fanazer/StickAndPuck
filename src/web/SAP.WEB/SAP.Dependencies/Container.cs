#region Using

using Microsoft.Extensions.DependencyInjection;

#endregion

namespace SAP.Dependencies
{
    public class Container
    {
        public Container(IServiceCollection collection)
        {
            new SAP.DataAccess.Dependencies(collection);
            new SAP.Business.Dependencies(collection);
            new SAP.Common.Dependencies(collection);
        }
    }
}
