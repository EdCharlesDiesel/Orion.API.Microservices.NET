using Orion.Core.Basket.Domain;

namespace Orion.Services.Intefaces;

public interface IBasketServices:IRepository<Basket>
{
    Task<List<Basket>?> BulkCreate(List<Basket>  baskets);
}