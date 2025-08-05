using AutoMapper;
using Orion.Services.Basket.API.DTO;

namespace Orion.Services.Basket.API.Mappings;

public class MappingProfile : Profile
{ public MappingProfile()
    {
        CreateMap<Core.Basket.Domain.Basket, BasketDto>().ReverseMap();
    }
}