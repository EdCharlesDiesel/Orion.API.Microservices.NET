namespace Orion.DataAccess.Postgres.Tools
{
    public interface IUnitOfWork
    {
        Task<bool> SaveEntitiesAsync();
        Task StartAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task<int> CompleteAsync();
       
    }
}
