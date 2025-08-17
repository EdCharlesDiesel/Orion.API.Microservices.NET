using Orion.Admin.Tools;
using Orion.Domain.Events;
using Orion.Domain.IRepositories;

namespace Orion.Admin.Handlers
{
    public class OrderDeleteEventHandler : IEventHandler<OrderDeleteEvent>
    {
        IOrderEventRepository repo;
        public OrderDeleteEventHandler(IOrderEventRepository repo)
        {
            this.repo = repo;
        }
        public async Task HandleAsync(OrderDeleteEvent ev)
        {
            // repo.New(OrderEventType.Deleted, ev.OrderId, ev.OldVersion);
            // return Task.CompletedTask;
        }
    }
}
