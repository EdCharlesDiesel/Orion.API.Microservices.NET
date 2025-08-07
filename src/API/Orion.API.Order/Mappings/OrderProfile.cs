using AutoMapper;
using Orion.API.Order.DTO;

namespace Orion.API.Order.Mappings;

public class OrderProfile : Profile
{

        public OrderProfile()
        {
            CreateMap<Core.Orders.Domain.Order, OrderDto>().ReverseMap();
        }
}