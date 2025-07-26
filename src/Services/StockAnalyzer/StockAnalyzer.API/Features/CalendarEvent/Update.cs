using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.DTO;
using FastEndpoints;
using MediatR;
using IMapper = AutoMapper.IMapper;
using Orion.Services.StockAnalyzer.API.Requests;

namespace Orion.Services.StockAnalyzer.API.Features.CalendarEvent;

public class UpdateHandler : IRequestHandler<UpdateCalendarEventRequest, CalendarEventDto?>
{
    private readonly StockAnalyzerContext _db;
    private readonly IMapper _mapper;

    public UpdateHandler(StockAnalyzerContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<CalendarEventDto?> Handle(UpdateCalendarEventRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
        // var CalendarEvent = await _db.CalendarEvents.FindAsync([request.Id]);
        // if (CalendarEvent is null) return null;
        //
        // CalendarEvent.CalendarId= request.CalendarId;
        // CalendarEvent.Importance= request.Importance;
        // CalendarEvent.Country= request.Country;
        // CalendarEvent.Category= request.Category;
        // CalendarEvent.Event= request.Event;
        // CalendarEvent.Source= request.Source;
        // CalendarEvent.SourceURL= request.SourceURL;
        // CalendarEvent.Actual= request.Actual;
        // CalendarEvent.Previous= request.Previous;
        // CalendarEvent.Forecast= request.Forecast;
        // CalendarEvent.TEForecast= request.TEForecast;
        // CalendarEvent.URL= request.URL;
        // CalendarEvent.DateSpan= request.DateSpan;
        // CalendarEvent.Revised= request.Revised;
        // CalendarEvent.Currency= request.Currency;
        // CalendarEvent.Unit= request.Unit;
        // CalendarEvent.Ticker= request.Ticker;
        // CalendarEvent.Symbol= request.Symbol;
        // CalendarEvent.Reference= request.Reference;
        //
        //
        // await _db.SaveChangesAsync();
        // return _mapper.Map<CalendarEventDto>(CalendarEvent);
    }
}

public class UpdateEndpoint : Endpoint<UpdateCalendarEventRequest, CalendarEventDto?>
{
    private readonly IMediator _mediator;

    public UpdateEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Put("/CalendarEvents/{id:guid}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateCalendarEventRequest req, CancellationToken ct)
    {
        var result = await _mediator.Send(req, ct);
        if (result is null)
            await SendNotFoundAsync();
        else
            await SendAsync(result);
    }
}