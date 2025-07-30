

using Orion.Core.Catalog.Domain;

namespace Orion.Services.Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public DbSet<Product> Products { get; set; }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
