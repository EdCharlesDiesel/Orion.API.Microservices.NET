using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.API.Catalog.Data
{
    public class CatalogContext(DbContextOptions<CatalogContext> options) : DbContext(options), ICatalogContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
