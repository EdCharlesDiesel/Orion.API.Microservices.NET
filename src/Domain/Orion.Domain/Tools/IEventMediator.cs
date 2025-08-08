using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orion.Domain.Tools
{
    public interface IEventMediator
    {
        Task TriggerEvents(IEnumerable<IEventNotification> events);
    }
}
