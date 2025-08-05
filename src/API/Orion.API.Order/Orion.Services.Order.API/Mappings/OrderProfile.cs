using AutoMapper;
using Orion.Services.Order.API.DTO;

namespace Orion.Services.Order.API.Mappings;

public class OrderProfile : Profile
{

        public OrderProfile()
        {
            CreateMap<Core.Order.Domain.Order, OrderDto>().ReverseMap();
        }
}