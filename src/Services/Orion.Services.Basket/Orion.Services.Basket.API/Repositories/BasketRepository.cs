using Orion.Core.TradingEconomics.Domain;
using Orion.Services.Basket.API.Data;
using Orion.Services.Basket.API.Helper;
using Orion.Services.Basket.API.Services;

namespace Orion.Services.Basket.API.Repositories;

public class BasketRepository: IBasketServices
{
    private readonly BasketContext _context;

    public BasketRepository(BasketContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Core.Basket.Domain.Basket>> GetAllAsync()
    {
        var baskets = _context.Baskets.ToList();
        if (baskets == null || !baskets.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        // Return the first created event (or you can change this to return the list)
        return baskets.ToList();
    }

    public async Task<string> GetBasketsByDate(DateTime startDate, DateTime endDate)
    {
        if (startDate == default || endDate == default)
            return "Invalid date range";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester($"/calendar/country/all/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetBasketsByCountries(params string[] countries)
    {
        if (countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid country names";

        return await HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}");
    }

    public async Task<string> GetBasketsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetBasketsByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await HttpRequesterClass.HttpRequester($"/calendar/indicator/{string.Join(",", indicators)}");
    }

    public async Task<Core.Basket.Domain.Basket> Create(Core.Basket.Domain.Basket baskets)
    {
        if (baskets == null)
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.Baskets.AddAsync(baskets);
        await _context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return baskets;
    }


    public async Task<Core.Basket.Domain.Basket> Create(List<Core.Basket.Domain.Basket> baskets)
    {
        if (baskets == null || !baskets.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.Baskets.AddRangeAsync(baskets);
        await _context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return baskets.First();
    }



    public async Task<Core.Basket.Domain.Basket?> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Core.Basket.Domain.Basket entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Core.Basket.Domain.Basket entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }
}