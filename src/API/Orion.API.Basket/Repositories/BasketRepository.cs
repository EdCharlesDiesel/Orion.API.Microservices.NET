using Orion.Services;
using Orion.Services.Basket.API.Data;
using Orion.Services.Basket.API.DTO;
using Orion.Services.Intefaces;

namespace Orion.API.Basket.Repositories;

public class BasketRepository(BasketContext context) : IBasketServices
{
    public async Task<Core.Basket.Domain.Basket> Create(List<Core.Basket.Domain.Basket> baskets)
    {
        if (baskets == null)
            throw new ArgumentException("basket list cannot be null or empty.");

        await context.Baskets.AddRangeAsync(baskets);
        await context.SaveChangesAsync();

        return baskets.First();
    }

    public Task<List<Core.Basket.Domain.Basket>> GetAllAsync()
    {
        var baskets = context.Baskets.ToList();
        if (baskets == null)
            throw new ArgumentException("basket list cannot be null or empty.");

        return Task.FromResult(baskets);
    }
    

    public async Task<Core.Basket.Domain.Basket?> GetByIdAsync(Guid id)
    {
        var baskets = context.Baskets.FindAsync(id);
        return await baskets;
    }

    public Task<BasketDto?> AddAsync(BasketDto basket)
    {
        if (basket == null)
            throw new ArgumentException("basket cannot be null or empty.");
        // await context.Baskets.AddAsync(basket);
        // await context.SaveChangesAsync();
        return Task.FromResult<BasketDto?>(null);
    }

    public async Task<Core.Basket.Domain.Basket?> AddAsync(Core.Basket.Domain.Basket basket)
    {
        if (basket == null)
            throw new ArgumentException("basket cannot be null or empty.");
        await context.Baskets.AddAsync(basket);
        await context.SaveChangesAsync();
        return null;
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