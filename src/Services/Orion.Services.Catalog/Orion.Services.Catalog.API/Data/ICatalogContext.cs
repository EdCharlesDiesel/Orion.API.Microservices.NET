using Microsoft.EntityFrameworkCore;
using Orion.Core.Catalog.Domain;

namespace Orion.Services.Catalog.API.Data
{
    public interface ICatalogContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
