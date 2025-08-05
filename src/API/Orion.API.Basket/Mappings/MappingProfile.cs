using AutoMapper;
using Orion.Services.Basket.API.DTO;

namespace Orion.API.Basket.Mappings;

public class MappingProfile : Profile
{ public MappingProfile()
    {
        CreateMap<Core.Basket.Domain.Basket, BasketDto>().ReverseMap();
    }
}