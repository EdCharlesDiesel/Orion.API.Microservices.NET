using MediatR;
using Orion.Services.StockAnalyzer.API.DTO;

namespace Orion.Services.StockAnalyzer.API.Requests;

public class GetCalendarEventByIdRequest : IRequest<CalendarEventDto?>
{
    public Guid Id { get; set; }
}