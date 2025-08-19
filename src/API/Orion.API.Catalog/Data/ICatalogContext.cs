using Microsoft.EntityFrameworkCore;

namespace Orion.API.Catalog.Data
{
    public interface ICatalogContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
