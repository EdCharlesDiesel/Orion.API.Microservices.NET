using AutoMapper;
using Orion.Core.TradingEconomics.Domain;
using Orion.Services.TradingEconomics.API.DTO;

namespace Orion.Services.TradingEconomics.API.Mappings;

public class CalendarEventProfile : Profile
{

        public CalendarEventProfile()
        {
            CreateMap<CalendarEvent, CalendarEventDto>().ReverseMap();
        }
}