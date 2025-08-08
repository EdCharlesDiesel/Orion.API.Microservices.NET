using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IRegionRepository:IRepository<IRegion>
    {
        Task<IRegion> Get(int id);
        IRegion New();
    }
}
