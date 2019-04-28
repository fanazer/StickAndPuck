namespace SAP.DataAccess.DbContext
{
    public interface IDbContextFactory
    {
        IDbContext Create();
    }
}