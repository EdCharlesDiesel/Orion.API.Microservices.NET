using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface IEmployeeEventRepository:IRepository<IEmployeeEvent>
    {
        Task<IEmployeeEvent> Get(int id);
        IEmployeeEvent New();
    }

    public interface IEmployeeEvent
    {
    }
}
