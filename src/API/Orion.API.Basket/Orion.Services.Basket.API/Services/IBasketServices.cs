using Orion.Services.Basket.API.DTO;

namespace Orion.Services.Basket.API.Services;

public interface IBasketServices:IRepository<Core.Basket.Domain.Basket>
{
    Task<List<BasketDto>> BulkCreate(List<Core.Basket.Domain.Basket>  baskets);
}