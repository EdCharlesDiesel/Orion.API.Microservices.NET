using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IOrderDetailEventRepository:IRepository<IOrderDetailEvent>
    {
        Task<IOrderDetailEvent> Get(int id);
        IOrderDetailEvent New();
    }
}
