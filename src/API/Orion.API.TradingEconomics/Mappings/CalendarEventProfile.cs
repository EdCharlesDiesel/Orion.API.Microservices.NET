using AutoMapper;
using Orion.API.TradingEconomics.API.DTO;
using Orion.Core.TradingEconomics.Domain;

namespace Orion.API.TradingEconomics.API.Mappings;

public class CalendarEventProfile : Profile
{

        public CalendarEventProfile()
        {
            CreateMap<CalendarEvent, CalendarEventDto>().ReverseMap();
        }
}