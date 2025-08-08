using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ITerritoryRepository:IRepository<ITerritory>
    {
        Task<ITerritory> Get(int id);
        ITerritory New();
    }
}
