using Orion.DataAccess.Postgres.IRepositories;

namespace Orion.DataAccess.Postgres.Tools
{
    public interface IUnitOfWork
    {
        IAwBuildVersionRepository AwBuildVersions { get; }
        IDatabaseLogRepository DatabaseLogs { get; }
        ITransactionHistoryArchivesRepository TransactionHistoryArchives { get; set; }
        IErrorLogsRepository ErrorLogs { get; set; }

        Task<bool> SaveEntitiesAsync();
        Task StartAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task<int> CompleteAsync();
    }
}
