using Orion.WebApps.WebASP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orion.WebApps.WebASP.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
