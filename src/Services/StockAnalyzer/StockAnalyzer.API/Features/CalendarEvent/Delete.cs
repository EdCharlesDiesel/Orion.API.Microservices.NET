using FastEndpoints;
using MediatR;
using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.Requests;


namespace Orion.Services.StockAnalyzer.API.Features.CalendarEvent;

public class DeleteHandler : IRequestHandler<DeleteCalendarEventRequest, bool>
{
    private readonly StockAnalyzerContext _db;
    private readonly IMapper _mapper;
    
    public DeleteHandler(StockAnalyzerContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<bool> Handle(DeleteCalendarEventRequest request, CancellationToken cancellationToken)
    {
        var calendarEvent = await _db.CalendarEvents.FindAsync(request.Id, cancellationToken);
        if (calendarEvent is null)
            return false;

        _db.CalendarEvents.Remove(calendarEvent);
        await _db.SaveChangesAsync(cancellationToken);

        return true;
    }

}

public class DeleteEndpoint : Endpoint<DeleteCalendarEventRequest>
{
    private readonly IMediator _mediator;

    public DeleteEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Delete("/CalendarEvents/{id:guid}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteCalendarEventRequest req, CancellationToken ct)
    {
        var success = await _mediator.Send(req, ct);
        if (!success)
            await SendNotFoundAsync();
        else
            await SendOkAsync();
    }
}
