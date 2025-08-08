using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IOrderEventRepository:IRepository<IOrderEvent>
    {
        Task<IOrderEvent> Get(int id);
        IOrderEvent New(OrderEventType deleted);
    }
}
