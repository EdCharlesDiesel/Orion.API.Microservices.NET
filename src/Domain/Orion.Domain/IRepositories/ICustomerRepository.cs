using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface ICustomerRepository:IRepository<ICustomer>
    {
        Task<ICustomer> Get(int id);
        ICustomer New();
        Task Delete(int customerId);
    }
}