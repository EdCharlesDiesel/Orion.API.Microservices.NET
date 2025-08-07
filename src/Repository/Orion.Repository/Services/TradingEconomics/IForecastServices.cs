using Orion.Core.TradingEconomics.Domain;

namespace Orion.Repository.Services.TradingEconomics;
public interface IForecastServices
{
    Task<string> GetForecasts();
    Task<string> GetForecastsByDate(DateTime startDate, DateTime endDate);
    Task<string> GetForecastsByCountries(params string[] countries);
    Task<string> GetForecastsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetForecastsByIndicator(params string[] indicators);
    Task<Forecast> Create(List<Forecast> forecasts);
}