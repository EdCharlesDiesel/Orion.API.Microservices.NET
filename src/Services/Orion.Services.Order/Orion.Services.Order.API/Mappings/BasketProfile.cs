using AutoMapper;
using Orion.Services.TradingEconomics.API.DTO;

namespace Orion.Services.Basket.API.Mappings;

public class BasketProfile : Profile
{

        public BasketProfile()
        {
            CreateMap<OrionUserProfile.Domain.UserProfile, BasketDto>().ReverseMap();
        }
}