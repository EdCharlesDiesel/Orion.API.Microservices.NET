using Microsoft.EntityFrameworkCore;

namespace Orion.Services.Catalog.API.Data
{
    public interface ICatalogContext
    {
        DbSet<Core.Catalog.Domain.Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
