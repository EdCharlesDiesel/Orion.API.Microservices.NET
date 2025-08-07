using Orion.Core.Catalog.Domain;

namespace Orion.Repository.Services.Orion;
public interface ICatalogServices:IRepository<Product>
{
    Task BulkCreate(List<Product> entity); 
}