using AutoMapper;
using Orion.API.CompetitionScorecard.DTO;
using Orion.Core.CompetitionScorecard.Domain;

namespace Orion.API.CompetitionScorecard.Mappings;

public class CouponProfile : Profile
{

        public CouponProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
}