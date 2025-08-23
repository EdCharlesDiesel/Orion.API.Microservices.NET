using AutoMapper;
using Orion.API.Catalog.DTO;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.API.Catalog.Mappings;

public class CatalogProfile : Profile
{

        public CatalogProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
}