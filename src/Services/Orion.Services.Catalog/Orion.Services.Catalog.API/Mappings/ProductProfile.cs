using AutoMapper;
using Orion.Core.Catalog.Domain;
using Orion.Services.Catalog_2.API.DTO;

namespace Orion.Services.Catalog.API.Mappings;

public class ProductProfile : Profile
{

        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
}