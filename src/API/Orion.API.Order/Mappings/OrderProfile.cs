using AutoMapper;
using Orion.API.Order.API.DTO;

namespace Orion.API.Order.API.Mappings;

public class OrderProfile : Profile
{

        public OrderProfile()
        {
            CreateMap<Core.Order.Domain.Order, OrderDto>().ReverseMap();
        }
}