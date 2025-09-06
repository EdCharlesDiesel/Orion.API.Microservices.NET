using Orion.DataAccess.Postgres.Data;
using Orion.Domain.IRepositories;

namespace Orion.DataAccess.Postgres.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrionDbContext _context;
        public IAwBuildVersionRepository AWBuildVersions { get; }

        public UnitOfWork(OrionDbContext context)
        {
            _context = context;
            AWBuildVersions = new AWBuildVersionRepository(_context);
        }

        public async Task<int> CompleteAsync() =>
            await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}