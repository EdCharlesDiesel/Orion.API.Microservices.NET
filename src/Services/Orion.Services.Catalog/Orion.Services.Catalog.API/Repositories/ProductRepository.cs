using Orion.Core.Catalog.Domain;
using Orion.Services.Catalog.API.Data;
using Orion.Services.Catalog.API.Services;

namespace Orion.Services.Catalog.API.Repositories
{

    public class ProductRepository : IProductServices
    {
        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
        public async Task<Product> GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public async Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProduct(string id)
        {
            throw new NotImplementedException();
            // FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, id);
            //
            // DeleteResult deleteResult = await _context
            //                                     .Products
            //                                     .DeleteOneAsync(filter);
            //
            // return deleteResult.IsAcknowledged
            //     && deleteResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product?> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }
    }
}

