using AutoMapper;
using Orion.DataAccess.Postgres.Entities;
using Orion.Domain.DTO;

namespace Orion.API.Catalog.Mappings;

public class CatalogProfile : Profile
{

        public CatalogProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
}