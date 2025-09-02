using System.Collections.Generic;
using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface IProductEventRepository:IRepository<IProductEvent>
    {
        Task<IEnumerable<IProductEvent>> GetFirstN(int n);
        IProductEvent New(ProductEventType type, int id, long oldVersion, long? newVersion= null, decimal unitPrice = 0);
    }
}
