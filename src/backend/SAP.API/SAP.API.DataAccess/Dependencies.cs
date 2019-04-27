#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.API.Common.Entities;
using SAP.API.Common.Entities.People;
using SAP.API.DataAccess.DbContext;
using SAP.API.DataAccess.Repositories;

#endregion

namespace SAP.API.DataAccess
{
    public sealed class Dependencies
    {
        public Dependencies(IServiceCollection collection)
        {
            collection.AddTransient<IRepository<Player>, PlayersRepository>();
            collection.AddSingleton<IDbContextFactory, DbContextFactory>();
            collection.AddTransient<IRepository<Team>, TeamsRepository>();
        }
    }
}