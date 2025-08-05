using AutoMapper;
using Orion.Services.Catalog.API.DTO;

namespace Orion.Services.Order.API.Mappings;

public class CatalogProfile : Profile
{

        public CatalogProfile()
        {
            CreateMap<Core.Order.Domain.Order, ProductDto>().ReverseMap();
        }
}