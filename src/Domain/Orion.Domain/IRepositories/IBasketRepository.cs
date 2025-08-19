using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orion.Domain.IRepositories;

public interface IBasketServices:IRepository<Basket>
{
    Task<List<Basket>?> BulkCreate(List<Basket>  baskets);
}

public class Basket
{
}