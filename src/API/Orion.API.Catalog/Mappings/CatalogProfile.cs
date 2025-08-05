using AutoMapper;
using Orion.API.Catalog.DTO;
using Orion.Core.Catalog.Domain;

namespace Orion.API.Catalog.Mappings;

public class CatalogProfile : Profile
{

        public CatalogProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
}