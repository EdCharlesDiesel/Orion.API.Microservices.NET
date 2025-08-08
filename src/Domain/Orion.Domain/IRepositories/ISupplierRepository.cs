using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ISupplierRepository:IRepository<ISupplier>
    {
        Task<ISupplier> Get(int id);
        ISupplier New();
    }
}
