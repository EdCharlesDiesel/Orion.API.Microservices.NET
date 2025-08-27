using AutoMapper;
using Orion.API.Order.DTO;
using Orion.DataAccess.Postgres.Entities.Common;

namespace Orion.API.Order.Mappings;

public class OrderProfile : Profile
{

        public OrderProfile()
        {
            CreateMap<OrderDetail, OrderDto>().ReverseMap();
        }
}