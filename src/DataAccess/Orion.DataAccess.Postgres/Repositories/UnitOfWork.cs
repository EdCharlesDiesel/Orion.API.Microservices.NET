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
            AWBuildVersions = new AwBuildVersionRepository(_context);
        }


        public async Task<bool> SaveEntitiesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task StartAsync() => Task.CompletedTask;

        public Task CommitAsync() => Task.CompletedTask;

        public Task RollbackAsync() => Task.CompletedTask;

        public async Task<int> CompleteAsync() =>
            await _context.SaveChangesAsync();

        public IAwBuildVersionRepository AWBuildVersions { get; set; }

        public void Dispose() => _context.Dispose();
    }


}