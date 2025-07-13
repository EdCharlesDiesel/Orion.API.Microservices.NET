using System.Threading.Tasks;
using Orion.Shopping.Aggregator.Models;

namespace Orion.Shopping.Aggregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);                
    }
}
