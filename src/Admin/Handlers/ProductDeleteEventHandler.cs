using Orion.Admin.Tools;
using Orion.Domain.Aggregates;
using Orion.Domain.Events;
using Orion.Domain.IRepositories;

namespace Orion.Admin.Handlers
{
    public class ProductDeleteEventHandler :
        IEventHandler<ProductDeleteEvent>
    {
        IProductEventRepository repo;
        public ProductDeleteEventHandler(IProductEventRepository repo)
        {
            this.repo = repo;
        }
        public Task HandleAsync(ProductDeleteEvent ev)
        {
            repo.New(ProductEventType.Deleted, ev.ProductId, ev.OldVersion);
            return Task.CompletedTask;
        }
    }
}
