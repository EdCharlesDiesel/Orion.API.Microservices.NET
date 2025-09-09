using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.IRepositories;

namespace Orion.DataAccess.Postgres.Repositories
{
    public class AwBuildVersionRepository(OrionDbContext context) : IAwBuildVersionRepository
    {
        public async Task<IEnumerable<AWBuildVersion>> GetAllAsync() =>
            await context.AwbuildVersion.ToListAsync();

        public async Task<AWBuildVersion?> GetByIdAsync(int id) =>
            await context.AwbuildVersion.FindAsync(id);

        public async Task AddAsync(AWBuildVersion entity) =>
            await context.AwbuildVersion.AddAsync(entity);

        public void Update(AWBuildVersion entity) =>
            context.AwbuildVersion.Update(entity);

        public void Delete(AWBuildVersion entity) =>
            context.AwbuildVersion.Remove(entity);
    }
}