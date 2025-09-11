using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.IRepositories;

namespace Orion.DataAccess.Postgres.Repositories;

public class TransactionHistoryArchivesRepository(OrionDbContext context): ITransactionHistoryArchivesRepository
{
    public async Task<IEnumerable<TransactionHistoryArchive>> GetAllAsync() =>
        await context.TransactionHistoryArchive.ToListAsync();

    public async Task<TransactionHistoryArchive?> GetByIdAsync(int id) =>
        await context.TransactionHistoryArchive.FindAsync(id);

    public async Task AddAsync(TransactionHistoryArchive entity) =>
        await context.TransactionHistoryArchive.AddAsync(entity);

    public void Update(TransactionHistoryArchive entity) =>
        context.TransactionHistoryArchive.Update(entity);

    public void Delete(TransactionHistoryArchive entity) =>
        context.TransactionHistoryArchive.Remove(entity);
}