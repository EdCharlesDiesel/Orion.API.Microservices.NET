using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface IFeatureRepository : IRepository<IFeature>
    {
        IFeature GetByUsername(string username);
        Task<IFeature> Get(int id);
        IFeature New();
    }
}
