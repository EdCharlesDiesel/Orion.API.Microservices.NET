using Orion.API.HumanResources.Models;

namespace Orion.API.HumanResources.MapperProfiles
{
    public class StatisticsProfile : Profile
    {
        public StatisticsProfile()
        {
            CreateMap<IHttpConnectionFeature, StatisticsDto>();
        }
    }
}
