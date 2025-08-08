using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IOrderDetailRepository:IRepository<IOrderDetail>
    {
        Task<IOrderDetail> Get(int id);
        IOrderDetail New();
    }
}
