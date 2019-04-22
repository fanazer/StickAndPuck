namespace SAP.API.DataAccess.DbContext
{
    public interface IDbContextFactory
    {
        IDbContext Create();
    }
}
