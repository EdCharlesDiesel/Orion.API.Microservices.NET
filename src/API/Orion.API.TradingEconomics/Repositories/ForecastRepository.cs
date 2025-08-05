using Orion.API.TradingEconomics.API.Data;
using Orion.API.TradingEconomics.API.Services;
using Orion.Core.TradingEconomics.Domain;
using Orion.Helpers;

namespace Orion.API.TradingEconomics.API.Repositories;

public class ForecastRepository : IForecastServices
{
    private readonly TradingEconomicsContext _context;

    public ForecastRepository(TradingEconomicsContext context)
    {
        _context = context;
    }

    public async Task<string> GetForecasts()
    {
        return await HttpRequesterClass.HttpRequester("/forecasts");
    }

    public async Task<string> GetForecastsByDate(DateTime startDate, DateTime endDate)
    {
        if (startDate == default || endDate == default)
            return "Invalid date range";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester($"/forecast/country/all/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetForecastsByCountries(params string[] countries)
    {
        if (countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid country names";

        return await HttpRequesterClass.HttpRequester($"/forecast/country/{string.Join(",", countries)}");
    }

    public async Task<string> GetForecastsByCountriesAndDates(DateTime startDate, DateTime endDate,
        params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester(
            $"/forecast/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetForecastsByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await HttpRequesterClass.HttpRequester($"/forecast/indicator/{string.Join(",", indicators)}");
    }

    public async Task<Forecast> Create(List<Forecast> forecastEvents)
    {
        if (forecastEvents == null || !forecastEvents.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.Forecast.AddRangeAsync(forecastEvents);
        await _context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return forecastEvents.First();
    }


}