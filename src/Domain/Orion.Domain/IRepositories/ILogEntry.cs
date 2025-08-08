using Orion.Domain.Aggregates;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.Domain.IRepositories
{
    public interface ILogEntryRepository:IRepository<ILogEntry>
    {
        Task<ILogEntry> Get(int id);
        ILogEntry New();
    }
}
