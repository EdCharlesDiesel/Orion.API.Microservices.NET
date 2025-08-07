


namespace Orion.API.Basket.Services;

public interface IBasketServices:IRepository<Core.Basket.Domain.Basket>
{
    Task<List<Core.Basket.Domain.Basket>?> BulkCreate(List<Core.Basket.Domain.Basket>  baskets);
}