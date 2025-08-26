using System.Globalization;
using AutoMapper;
using Orion.API.HumanResources.Models;

namespace Orion.API.HumanResources.MapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        { 
            CreateMap<Calendar, CalendarDto>(); 
        }
    }
}
