#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.Common.Entities;
using SAP.Common.Entities.People;
using SAP.DataAccess.DbContext;
using SAP.DataAccess.Repositories;

#endregion

namespace SAP.DataAccess
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