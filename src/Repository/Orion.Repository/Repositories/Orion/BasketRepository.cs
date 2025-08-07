using Orion.Core.Basket.Domain;
using Orion.Repository.Data;
using Orion.Repository.Services;
using Orion.Repository.Services.Orion;

namespace Orion.Repository.Repositories.Orion;

public class BasketRepository(OrionDbContext context) : IBasketServices
{
    public async Task<Core.Basket.Domain.Basket> Create(List<Core.Basket.Domain.Basket> baskets)
    {
        if (baskets == null)
            throw new ArgumentException("basket list cannot be null or empty.");

        await context.Baskets.AddRangeAsync(baskets);
        await context.SaveChangesAsync();

        return baskets.First();
    }

    //TODO: Fix later
    public async Task<IEnumerable<Basket>> GetAllAsync()
    {
        var baskets = context.Baskets.ToList();
        if (baskets == null)
            throw new ArgumentException("basket list cannot be null or empty.");
        
        return baskets.ToList();
        
    }
    

    public async Task<Core.Basket.Domain.Basket?> GetByIdAsync(Guid id)
    {
        var baskets = context.Baskets.FindAsync(id);
        return await baskets;
    }

  

    public async Task AddAsync(Basket basket)
    {
        if (basket == null)
            throw new ArgumentException("basket cannot be null or empty.");
        await context.Baskets.AddAsync(basket);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Core.Basket.Domain.Basket basket)
    {
        if (basket == null)
            throw new ArgumentException("basket cannot be null or empty.");
        context.Baskets.Update(basket);
        await context.SaveChangesAsync();
       
    }

    public async Task DeleteAsync(Guid id)
    {
        var basket = await GetByIdAsync(id);
        if (basket == null)
            throw new ArgumentException("basket cannot be null or empty.");
        context.Baskets.Remove(basket);
    }

    public async Task<List<Core.Basket.Domain.Basket>?> BulkCreate(List<Core.Basket.Domain.Basket> baskets)
    {
        await context.AddRangeAsync(baskets);
        if (baskets == null)
            throw new ArgumentException("basket cannot be null or empty.");
        await context.AddRangeAsync(baskets);
        return null;
    }

    public async Task<List<Core.Basket.Domain.Basket>> BulkCreate(Core.Basket.Domain.Basket baskets)
    {
        if (baskets == null)
            throw new ArgumentException("basket cannot be null or empty.");
        await context.Baskets.AddRangeAsync(baskets);
        await context.SaveChangesAsync();
        return null!;
    }
}