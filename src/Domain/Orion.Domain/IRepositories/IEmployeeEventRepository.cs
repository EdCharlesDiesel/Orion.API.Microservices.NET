using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface IEmployeeEventRepository:IRepository<IEmployeeEvent>
    {
        Task<IEmployeeEvent> Get(int id);
        IEmployeeEvent New();
    }
}
