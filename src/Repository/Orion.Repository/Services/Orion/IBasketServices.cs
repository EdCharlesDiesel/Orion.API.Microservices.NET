using Orion.Core.Basket.Domain;

namespace Orion.Repository.Services.Orion;

public interface IBasketServices:IRepository<Basket>
{
    Task<List<Basket>?> BulkCreate(List<Basket>  baskets);
}