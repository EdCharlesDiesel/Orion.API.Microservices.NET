using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.Services;
using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Services.StockAnalyzer.API.Repositories;

public class CalendarRepository: ICalendarServices
{
    private readonly StockAnalyzerContext _context;

    public CalendarRepository(StockAnalyzerContext context)
    {
        _context = context;
    }
    public async Task<string> GetCalendarEvents()
    {
        return await Helper.HttpRequesterClass.HttpRequester("/calendar");
    }

    public async Task<string> GetCalendarEventsByDate(DateTime startDate, DateTime endDate)
    {
        if (startDate == default || endDate == default)
            return "Invalid date range";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/country/all/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetCalendarEventsByCountries(params string[] countries)
    {
        if (countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid country names";

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}");
    }

    public async Task<string> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetCalendarEventsByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/indicator/{string.Join(",", indicators)}");
    }


    public async Task<CalendarEvent> Create(List<CalendarEvent> calendarEvents)
    {
        if (calendarEvents == null || !calendarEvents.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.CalendarEvents.AddRangeAsync(calendarEvents);
        await _context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return calendarEvents.First();
    }


}