

using Microsoft.EntityFrameworkCore;
using Orion.Core.Catalog.Domain;

namespace Orion.Services.Catalog.API.Data
{
    public class CatalogContext(DbContextOptions<CatalogContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
