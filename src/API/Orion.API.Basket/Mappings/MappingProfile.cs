using AutoMapper;
using Orion.API.Basket.DTO;

namespace Orion.API.Basket.Mappings;

public class MappingProfile : Profile
{ public MappingProfile()
    {
        CreateMap<DataAccess.Postgres.Entities.Basket, BasketDto>().ReverseMap();
    }
}