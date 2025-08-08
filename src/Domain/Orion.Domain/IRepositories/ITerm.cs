using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ITermRepository:IRepository<ITerm>
    {
        Task<ITerm> Get(int id);
        ITerm New();
    }
}
