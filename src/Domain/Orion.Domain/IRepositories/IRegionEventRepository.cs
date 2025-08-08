using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IIRegionEventRepository:IRepository<IRegionEvent>
    {
        Task<IRegionEvent> Get(int id);
        IRegionEvent New();
    }
}
