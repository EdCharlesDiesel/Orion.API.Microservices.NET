using System.Collections.Generic;
using System.Threading.Tasks;
using Orion.Domain.Aggregates;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IFeatureRepository : IRepository<IFeature>
    {
        IFeature GetByUsername(string username);
        Task<IFeature> Get(int id);
        IFeature New();
    }
}
