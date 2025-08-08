using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ILogEntryEventRepository:IRepository<ILogEntryEvent>
    {
        Task<ILogEntryEvent> Get(int id);
        ILogEntryEvent New();
    }
}
