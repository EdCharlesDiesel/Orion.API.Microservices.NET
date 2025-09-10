using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.IRepositories;
using Orion.DataAccess.Postgres.Tools;

namespace Orion.DataAccess.Postgres.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrionDbContext _context;

        public UnitOfWork(OrionDbContext context)
        {
            _context = context;
            AwBuildVersions = new AwBuildVersionRepository(_context);
            DatabaseLogs = new DatabaseLogRepository(_context);
        }

        public IAwBuildVersionRepository AwBuildVersions { get; set; }
        public IDatabaseLogRepository DatabaseLogs { get; set; }

        public Task StartAsync() => Task.CompletedTask;

        public Task CommitAsync() => Task.CompletedTask;

        public Task RollbackAsync() => Task.CompletedTask;
        
        public async Task<bool> SaveEntitiesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> CompleteAsync() =>
            await _context.SaveChangesAsync();
        
        public void Dispose() => _context.Dispose();
    }


}