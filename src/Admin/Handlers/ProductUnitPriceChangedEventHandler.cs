using Orion.Admin.Tools;
using Orion.Domain.Aggregates;
using Orion.Domain.Events;
using Orion.Domain.IRepositories;

namespace Orion.Admin.Handlers
{
    public class ProductUnitPriceChangedEventHandler :
        IEventHandler<ProductUnitPriceChangedEvent>
    {
        IProductEventRepository repo;
        public ProductUnitPriceChangedEventHandler(IProductEventRepository repo)
        {
            this.repo = repo;
        }
        public Task HandleAsync(ProductUnitPriceChangedEvent ev)
        {
            repo.New(ProductEventType.PriceChanged, ev.ProductId, ev.OldVersion, ev.NewVersion, ev.NewUnitPrice);
            return Task.CompletedTask;
        }
    }
}
