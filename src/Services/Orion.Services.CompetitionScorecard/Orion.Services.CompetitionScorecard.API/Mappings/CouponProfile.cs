using AutoMapper;
using Orion.Core.CompetitionScorecard.Domain;
using Orion.Services.TradingEconomics.API.DTO;

namespace Orion.Services.CompetitionScorecard.API.Mappings;

public class CouponProfile : Profile
{

        public CouponProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
}