using AutoMapper;
using Orion.Core.TradingEconomics.Domain;
using Orion.Services.TradingEconomics.API.DTO;

namespace Orion.Services.UserProfile.API.Mappings;

public class UserProfileProfile : Profile
{

        public UserProfileProfile()
        {
            CreateMap<OrionUserProfile.Domain.UserProfile, UserProfileDto>().ReverseMap();
        }
}