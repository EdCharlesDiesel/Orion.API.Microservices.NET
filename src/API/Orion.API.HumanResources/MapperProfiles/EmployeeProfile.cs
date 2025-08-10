using Orion.API.HumanResources.DataAccess.Entities;
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
