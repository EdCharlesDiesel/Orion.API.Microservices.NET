using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.IRepositories;

namespace Orion.DataAccess.Postgres.Repositories
{
    public class DatabaseLogRepository(OrionDbContext context) : IDatabaseLogRepository
    {
        public async Task<IEnumerable<DatabaseLog>> GetAllAsync() =>
            await context.DatabaseLog.ToListAsync();

        public async Task<DatabaseLog?> GetByIdAsync(int id) =>
            await context.DatabaseLog.FindAsync(id);

        public async Task AddAsync(DatabaseLog entity) =>
            await context.DatabaseLog.AddAsync(entity);

        public void Update(DatabaseLog entity) =>
            context.DatabaseLog.Update(entity);

        public void Delete(DatabaseLog entity) =>
            context.DatabaseLog.Remove(entity);
    }
}