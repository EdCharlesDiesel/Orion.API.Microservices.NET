using Orion.API.Basket.Services;
using Orion.Core.Catalog.Domain;


namespace Orion.API.Catalog.Services;

public interface ICatalogServices:IRepository<Product>
{
    Task BulkCreate(List<Product> entity); 
}