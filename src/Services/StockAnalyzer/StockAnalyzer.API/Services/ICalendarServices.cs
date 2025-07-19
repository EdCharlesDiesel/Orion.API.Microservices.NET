namespace Orion.Services.StockAnalyzer.API.Repositories;

public interface ICalendarServices
{
    Task<string> GetCalendarEvents();
    Task<string> GetCalendarEventsByDate(DateTime startDate, DateTime endDate);
    Task<string> GetCalendarEventsByCountries(params string[] countries);
    Task<string> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetCalendarEventsByIndicator(params string[] indicators);
}