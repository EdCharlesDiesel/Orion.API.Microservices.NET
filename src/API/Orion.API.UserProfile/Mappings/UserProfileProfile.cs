using AutoMapper;
using Orion.API.UserProfile.API.DTO;

namespace Orion.API.UserProfile.API.Mappings;

public class UserProfileProfile : Profile
{

        public UserProfileProfile()
        {
            CreateMap<OrionUserProfile.Domain.UserProfile, UserProfileDto>().ReverseMap();
        }
}