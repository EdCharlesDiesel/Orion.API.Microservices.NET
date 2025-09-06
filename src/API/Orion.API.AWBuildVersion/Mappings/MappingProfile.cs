using AutoMapper;
using Orion.API.AWBuildVersion.DTO;

namespace Orion.API.AWBuildVersion.Mappings;

public class MappingProfile : Profile
{ public MappingProfile()
    {
        CreateMap<DataAccess.Postgres.Entities.Common.Basket, BasketDto>().ReverseMap();
    }
}