using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ITerritoryEventRepository:IRepository<ITerritoryEvent>
    {
        Task<ITerritoryEvent> Get(int id);
        ITerritoryEvent New();
    }
}
