using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.Entities;
using Orion.Domain.IRepositories;

namespace Orion.DataAccess.Postgres.Repositories
{
    public class AWBuildVersionRepository : IAwBuildVersionRepository
    {
        private readonly OrionDbContext _context;

        public AWBuildVersionRepository(OrionDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AWBuildVersion>> GetAllAsync() =>
            await _context.AWBuildVersion.ToListAsync();

        public async Task<AWBuildVersion?> GetByIdAsync(int id) =>
            await _context.AWBuildVersion.FindAsync(id);

        public async Task AddAsync(AWBuildVersion entity) =>
            await _context.AWBuildVersion.AddAsync(entity);

        public void Update(AWBuildVersion entity) =>
            _context.AWBuildVersion.Update(entity);

        public void Delete(AWBuildVersion entity) =>
            _context.AWBuildVersion.Remove(entity);
    }
}