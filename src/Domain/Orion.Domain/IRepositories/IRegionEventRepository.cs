using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface IIRegionEventRepository:IRepository<IRegionEvent>
    {
        Task<IRegionEvent> Get(int id);
        IRegionEvent New();
    }
}
