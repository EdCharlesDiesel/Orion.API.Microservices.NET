using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orion.Domain.IRepositories;
public interface ICatalogServices:IRepository<Product>
{
    Task BulkCreate(List<Product> entity); 
}