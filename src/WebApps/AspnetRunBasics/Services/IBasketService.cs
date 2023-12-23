using Orion.WebApps.WebASP.Models;
using System.Threading.Tasks;

namespace Orion.WebApps.WebASP.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
        Task<BasketModel> UpdateBasket(BasketModel model);
        Task CheckoutBasket(BasketCheckoutModel model);
    }
}
