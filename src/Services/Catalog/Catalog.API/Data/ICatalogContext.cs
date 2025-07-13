using MongoDB.Driver;
using Orion.Services.Catalog.API.Entities;

namespace Orion.Services.Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
