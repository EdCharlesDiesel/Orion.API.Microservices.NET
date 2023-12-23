using AutoMapper;
using Orion.Services.Discount.Grpc.Entities;
using Orion.Services.Discount.Grpc.Protos;

namespace Orion.Services.Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
