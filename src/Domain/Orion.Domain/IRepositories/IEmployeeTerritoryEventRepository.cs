using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IEmployeeTerritoryEventRepository:IRepository<IEmployeeTerritoryEvent>
    {
        Task<IEmployeeTerritoryEvent> Get(int id);
        IEmployeeTerritoryEvent New();
    }
}
