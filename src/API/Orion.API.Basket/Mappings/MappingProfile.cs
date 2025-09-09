using AutoMapper;
using Orion.Domain.DTO;

namespace Orion.API.Basket.Mappings;

public class MappingProfile : Profile
{ public MappingProfile()
    {
        CreateMap<DataAccess.Postgres.Entities.Common.Basket, BasketDto>().ReverseMap();
    }
}