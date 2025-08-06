using Orion.Services.Intefaces;

namespace Orion.Services.Repository;

public class CatalogRepository(CatalogContext context) : ICatalogServices
{
    public async Task<List<Core.Catalog.Domain.Product>> GetAllAsync()
    {
        var products =  context.Products.ToList();
        if (products == null || !products.Any())
            throw new ArgumentException("products be null or empty.");

        return products.ToList();
    }
    public async Task<List<Core.Catalog.Domain.Product>> CreateProducts(List<Core.Catalog.Domain.Product> products)
    {
        if (products == null)
            throw new ArgumentException("product be null or empty.");

        await context.Products.AddRangeAsync(products);
        await context.SaveChangesAsync();
        
        return products;
    }

    //TODO: Add comments
    public async Task<Core.Catalog.Domain.Product> Create(List<Core.Catalog.Domain.Product> products)
    {
        if (products == null || !products.Any())
            throw new ArgumentException("product be null or empty.");

        await context.Products.AddRangeAsync(products);
        await context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return products.First();
    }

    // public async Task<Core.Catalog.Domain.Product?> GetByIdAsync(object id)
    // {
    //     throw new NotImplementedException();
    // }

    public async Task<Core.Catalog.Domain.Product?> GetByIdAsync(Guid id)
    {
        var product =  context.Products.FirstOrDefault(x => x.Id == id);
        if (product == null )
            throw new ArgumentException("product id cannot be null or empty.");

        return product;
    }

    public async Task<Core.Catalog.Domain.Product> AddAsync(Core.Catalog.Domain.Product product)
    {
        if (product == null)
            throw new ArgumentException("Product cannot be null or empty.");

        await context.Products.AddAsync(product);
        await context.SaveChangesAsync();


        return product;
    }

    public async Task<Core.Catalog.Domain.Product> UpdateAsync(Core.Catalog.Domain.Product entity)
    {
        var product =  context.Products.FirstOrDefault(x => x.Id == entity.Id);
        if (product == null)
            throw new ArgumentException("Product cannot be null or empty.");

        context.Products.Update(product);
        await context.SaveChangesAsync();
        return product;
    }

    public async Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        var product =  context.Products.FirstOrDefault(x => x.Id == id);
        if (product == null)
            throw new ArgumentException("Product cannot be null or empty.");

        context.Products.Remove(product);
        await context.SaveChangesAsync();
    }
    
    public async Task BulkCreate(List<Core.Catalog.Domain.Product> products)
    {
        if (products == null)
            throw new ArgumentException("Products cannot be null or empty.");

        await context.Products.AddRangeAsync(products);
        await context.SaveChangesAsync();
    }
}