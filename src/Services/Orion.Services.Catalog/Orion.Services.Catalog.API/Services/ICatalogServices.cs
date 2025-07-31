namespace Orion.Services.Catalog.API.Services;

public interface ICatalogServices:IRepository<Core.Catalog.Domain.Product>
{
    Task BulkCreate(List<Core.Catalog.Domain.Product> entity); 
}