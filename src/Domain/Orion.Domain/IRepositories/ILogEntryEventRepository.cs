using System.Threading.Tasks;
using Orion.Domain.Aggregates;

namespace Orion.Domain.IRepositories
{
    public interface ILogEntryEventRepository:IRepository<ILogEntryEvent>
    {
        Task<ILogEntryEvent> Get(int id);
        ILogEntryEvent New();
    }
}
