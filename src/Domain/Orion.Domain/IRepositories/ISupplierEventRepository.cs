using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ISupplierEventRepository:IRepository<ISupplierEvent>
    {
        Task<ISupplierEvent> Get(int id);
        ISupplierEvent New();
    }
}
