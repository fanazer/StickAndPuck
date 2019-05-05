#region Using

using Microsoft.Extensions.DependencyInjection;
using SAP.DataAccess.DbContext;
using SAP.DataAccess.Repositories;
using SAP.DataAccess.Repositories.Contracts;

#endregion

namespace SAP.DataAccess
{
    public sealed class Dependencies
    {
        public Dependencies(IServiceCollection collection)
        {
            collection.AddTransient<IPlayersRepository, PlayersesRepository>();
            collection.AddSingleton<IDbContextFactory, DbContextFactory>();
            collection.AddTransient<ITeamsRepository, TeamsesRepository>();
        }
    }
}