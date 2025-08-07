using AutoMapper;
using Orion.API.TradingEconomics.DTO;
using Orion.Core.TradingEconomics.Domain;

namespace Orion.API.TradingEconomics.Mappings;

public class CalendarEventProfile : Profile
{

        public CalendarEventProfile()
        {
            CreateMap<CalendarEvent, CalendarEventDto>().ReverseMap();
        }
}