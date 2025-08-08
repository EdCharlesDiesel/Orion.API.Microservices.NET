using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IEmployeeTerritoryRepository:IRepository<IEmployeeTerritory>
    {
        Task<IEmployeeTerritory> Get(int id);
        IEmployeeTerritory New();
    }
}
