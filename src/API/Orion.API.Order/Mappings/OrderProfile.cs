using AutoMapper;
using Orion.API.Order.DTO;

namespace Orion.API.Order.Mappings;

public class OrderProfile : Profile
{

        public OrderProfile()
        {
            CreateMap<DataAccess.Postgres.Entities.Order, OrderDto>().ReverseMap();
        }
}