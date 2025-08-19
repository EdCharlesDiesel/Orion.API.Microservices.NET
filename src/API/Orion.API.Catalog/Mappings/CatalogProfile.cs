using AutoMapper;
using Orion.API.Catalog.DTO;

namespace Orion.API.Catalog.Mappings;

public class CatalogProfile : Profile
{

        public CatalogProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
}