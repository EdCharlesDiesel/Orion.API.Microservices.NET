using System.Collections.Generic;
using System.Threading.Tasks;
using Orion.Repository.Services;

namespace Orion.Domain.IRepositories;
public interface ICatalogServices:IRepository<Product>
{
    Task BulkCreate(List<Product> entity); 
}