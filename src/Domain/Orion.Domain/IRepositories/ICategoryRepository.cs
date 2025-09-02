using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface ICategoryRepository:IRepository<ICategory>
    {
        Task<ICategory> Get(int id);
        ICategory New();
    }
}
