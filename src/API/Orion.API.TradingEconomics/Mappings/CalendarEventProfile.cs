using AutoMapper;
using Orion.API.TradingEconomics.DTO;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.API.TradingEconomics.Mappings;

public class CalendarEventProfile : Profile
{

        public CalendarEventProfile()
        {
            CreateMap<CalendarEvent, CalendarEventDto>().ReverseMap();
        }
}