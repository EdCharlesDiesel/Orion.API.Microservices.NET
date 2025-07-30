
using Orion.Core.Chat.Domain;

namespace Orion.Services.Chat.Services;

public interface ICalendarServices
{
    Task<string> GetChatRequests();
    Task<string> GetChatRequestsByDate(DateTime startDate, DateTime endDate);
    Task<string> GetChatRequestsByCountries(params string[] countries);
    Task<string> GetChatRequestsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetChatRequestsByIndicator(params string[] indicators);
    Task<ChatRequest> Create(List<ChatRequest> calendarEvents);
}