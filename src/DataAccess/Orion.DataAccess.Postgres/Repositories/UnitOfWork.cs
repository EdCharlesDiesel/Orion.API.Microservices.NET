using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.Tools;
using Orion.Domain.IRepositories;

namespace Orion.DataAccess.Postgres.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrionDbContext _context;

        public UnitOfWork(OrionDbContext context)
        {
            _context = context;
            // AWBuildVersions = new AWBuildVersionRepository(_context);
        }

        public async Task<bool> SaveEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task StartAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public async Task RollbackAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> CompleteAsync() =>
            await _context.SaveChangesAsync();

        public object AWBuildVersions { get; set; }

        public void Dispose() => _context.Dispose();
    }


}