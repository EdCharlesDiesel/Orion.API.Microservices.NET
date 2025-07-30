using FastEndpoints;
using MediatR;
using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.DTO;
using IMapper = AutoMapper.IMapper;

namespace Orion.Services.StockAnalyzer.API.Features.CalendarEvent;

 public class CreateCalendarEventRequest : IRequest<CalendarEventDto>
 {
     public string Name { get; set; } = string.Empty;
     public decimal Price { get; set; }
 }

 public class CreateCalendarEventHandler : IRequestHandler<CreateCalendarEventRequest, CalendarEventDto>
 {
     private readonly StockAnalyzerContext _db;
     private readonly IMapper _mapper;

     public CreateCalendarEventHandler(StockAnalyzerContext db, IMapper mapper)
     {
         _db = db;
         _mapper = mapper;
     }

     public async Task<CalendarEventDto> Handle(CreateCalendarEventRequest request, CancellationToken cancellationToken)
     {
         var CalendarEvent = _mapper.Map<Core.TradingEconomics.Domain.CalendarEvent>(request);
         CalendarEvent.Id = Guid.NewGuid();

         _db.CalendarEvents.Add(CalendarEvent);
         await _db.SaveChangesAsync();

         return _mapper.Map<CalendarEventDto>(CalendarEvent);
     }
 }

 public class CreateEndpoint : Endpoint<CreateCalendarEventRequest, CalendarEventDto>
 {
     private readonly IMediator _mediator;

     public CreateEndpoint(IMediator mediator)
     {
         _mediator = mediator;
     }

     public override void Configure()
     {
         Post("/CalendarEvents");
         AllowAnonymous();
     }

     public override async Task HandleAsync(CreateCalendarEventRequest req, CancellationToken ct)
     {
         var result = await _mediator.Send(req, ct);
         await SendAsync(result);
     }
}
