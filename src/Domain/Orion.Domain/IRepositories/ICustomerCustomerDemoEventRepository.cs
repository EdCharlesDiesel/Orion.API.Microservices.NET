using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ICustomerCustomerDemoEvent:IRepository<ICustomerCustomerDemoEvent>
    {
        Task<ICustomerCustomerDemoEvent> Get(int id);
        ICustomerCustomerDemoEvent New();
    }
}
