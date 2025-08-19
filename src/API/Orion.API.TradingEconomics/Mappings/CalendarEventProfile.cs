using AutoMapper;
using Orion.API.TradingEconomics.DTO;

namespace Orion.API.TradingEconomics.Mappings;

public class CalendarEventProfile : Profile
{

        public CalendarEventProfile()
        {
            CreateMap<CalendarEvent, CalendarEventDto>().ReverseMap();
        }
}