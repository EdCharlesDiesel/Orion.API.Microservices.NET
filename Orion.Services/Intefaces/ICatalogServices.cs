using Orion.Core.Catalog.Domain;

namespace Orion.Services.Intefaces;

public interface ICatalogServices:IRepository<Product>
{
    Task BulkCreate(List<Product> entity); 
}