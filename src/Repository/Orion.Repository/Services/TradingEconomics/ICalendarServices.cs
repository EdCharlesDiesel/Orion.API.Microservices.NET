using Orion.Core.TradingEconomics.Domain;

namespace Orion.Repository.Services.TradingEconomics;
public interface ICalendarServices:IRepository<CalendarEvent>
{
    Task<string> GetCalendarEvents();
    Task<string> GetCalendarEventsByDate(DateTime startDate, DateTime endDate);
    Task<string> GetCalendarEventsByCountries(params string[] countries);
    Task<string> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetCalendarEventsByIndicator(params string[] indicators);
    Task<CalendarEvent> Create(List<CalendarEvent> calendarEvents);
    Task<CalendarEvent?> GetCalendarEventsByIndicators(string[] names);
}