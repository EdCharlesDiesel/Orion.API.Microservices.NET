using FastEndpoints;
using MediatR;
using IMapper = AutoMapper.IMapper;
using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.DTO;
using Orion.Services.StockAnalyzer.API.Requests;

namespace Orion.Services.StockAnalyzer.API.Features.CalendarEvent;


public class GetByIdHandler : IRequestHandler<GetCalendarEventByIdRequest, CalendarEventDto?>
{
    private readonly StockAnalyzerContext _db;
    private readonly IMapper _mapper;

    public GetByIdHandler(StockAnalyzerContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<CalendarEventDto?> Handle(GetCalendarEventByIdRequest request, CancellationToken cancellationToken)
    {
        var CalendarEvent = await _db.CalendarEvents.FindAsync([request.Id]);
        return CalendarEvent is null ? null : _mapper.Map<CalendarEventDto>(CalendarEvent);
    }
}

public class GetByIdEndpoint : Endpoint<GetCalendarEventByIdRequest, CalendarEventDto?>
{
    private readonly IMediator _mediator;

    public GetByIdEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("/CalendarEvents/{id:guid}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetCalendarEventByIdRequest req, CancellationToken ct)
    {
        var result = await _mediator.Send(req, ct);
        if (result is null)
            await SendNotFoundAsync();
        else
            await SendAsync(result);
    }
}
