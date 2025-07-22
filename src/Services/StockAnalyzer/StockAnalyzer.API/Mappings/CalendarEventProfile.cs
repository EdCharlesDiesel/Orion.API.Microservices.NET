using Orion.StockAnalyzer.Core.Domain;
using AutoMapper;
using Orion.Services.StockAnalyzer.API.DTO;

namespace Orion.Services.StockAnalyzer.API.Mappings;

public class CalendarEventProfile : Profile
{

        public CalendarEventProfile()
        {
            CreateMap<CalendarEvent, CalendarEventDto>().ReverseMap();
        }
}