using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orion.DataAccess.Models;

namespace Orion.DataAccess.Repositories;

public class CalendarRepository : Repository<CalendarEvent>
{
    private readonly OrionDbContext _context;

    public CalendarRepository(OrionDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<string> GetCalendarEvents()
    {
        return await HttpRequesterClass.HttpRequester("/calendar");
    }

    public async Task<string> GetCalendarEventsByDate(DateTime startDate, DateTime endDate)
    {
        if (startDate == default || endDate == default)
            return "Invalid date range";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester($"/calendar/country/all/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetCalendarEventsByCountries(params string[] countries)
    {
        if (countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid country names";

        return await HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}");
    }

    public async Task<string> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate,
        params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester(
            $"/calendar/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetCalendarEventsByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await HttpRequesterClass.HttpRequester($"/calendar/indicator/{string.Join(",", indicators)}");
    }


    public async Task<CalendarEvent> Create(List<CalendarEvent> calendarEvents)
    {
        if (calendarEvents == null || !calendarEvents.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.CalendarEvents.AddRangeAsync(calendarEvents);
        await _context.SaveChangesAsync();
        
        return calendarEvents.First();
    }
}