using Microsoft.EntityFrameworkCore;
using Orion.Services.Catalog.API.Data;

namespace Orion.Services.Product.API.Data
{
    public class CatalogContext(DbContextOptions<CatalogContext> options) : DbContext(options), ICatalogContext
    {
        public DbSet<Core.Catalog.Domain.Product> Products { get; set; }
    }
}
