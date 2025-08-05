using Orion.Core.TradingEconomics.Domain;

namespace Orion.Services.TradingEconomics.API.Services;

public interface ICalendarServices
{
    Task<string> GetCalendarEvents();
    Task<string> GetCalendarEventsByDate(DateTime startDate, DateTime endDate);
    Task<string> GetCalendarEventsByCountries(params string[] countries);
    Task<string> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetCalendarEventsByIndicator(params string[] indicators);
    Task<CalendarEvent> Create(List<CalendarEvent> calendarEvents);
}