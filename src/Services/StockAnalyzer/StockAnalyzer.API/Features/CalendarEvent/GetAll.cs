using FastEndpoints;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.DTO;
using IMapper = AutoMapper.IMapper;

namespace Orion.Services.StockAnalyzer.API.Features.CalendarEvent;

public class GetAllCalendarEventsRequest : IRequest<List<CalendarEventDto>> { }

public class GetAllCalendarEventsHandler : IRequestHandler<GetAllCalendarEventsRequest, List<CalendarEventDto>>
{
    private readonly StockAnalyzerContext _db;
    private readonly IMapper _mapper;

    public GetAllCalendarEventsHandler(StockAnalyzerContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<List<CalendarEventDto>> Handle(GetAllCalendarEventsRequest request, CancellationToken cancellationToken)
    {
        var CalendarEvents = await _db.CalendarEvents.ToListAsync(cancellationToken);
        return _mapper.Map<List<CalendarEventDto>>(CalendarEvents);
    }
}

public class GetAllEndpoint : EndpointWithoutRequest<List<CalendarEventDto>>
{
    private readonly IMediator _mediator;

    public GetAllEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("/CalendarEvents");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var result = await _mediator.Send(new GetAllCalendarEventsRequest(), ct);
        await SendAsync(result);
    }
}