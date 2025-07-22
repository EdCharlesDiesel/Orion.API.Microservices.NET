using MediatR;

namespace Orion.Services.StockAnalyzer.API.Requests;

public class DeleteCalendarEventRequest : IRequest<bool>
{
    public Type Id { get; set; }
}