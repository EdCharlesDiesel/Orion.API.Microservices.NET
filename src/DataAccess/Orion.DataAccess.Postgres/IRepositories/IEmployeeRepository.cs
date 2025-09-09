using System.Threading.Tasks;
using Orion.DataAccess.Postgres.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface IEmployeeRepository:IRepository<IEmployee>
    {
        Task<IEmployee> Get(int id);
        IEmployee New();
    }
}
