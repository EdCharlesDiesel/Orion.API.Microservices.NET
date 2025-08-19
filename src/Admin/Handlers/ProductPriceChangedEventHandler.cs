using Orion.Admin.Tools;

namespace Orion.Admin.Handlers
{
    public class PackagePriceChangedEventHandler :
        IEventHandler<PackagePriceChangedEvent>
    {
        IPackageEventRepository repo;
        public PackagePriceChangedEventHandler(IPackageEventRepository repo)
        {
            this.repo = repo;
        }
        public Task HandleAsync(PackagePriceChangedEvent ev)
        {
            repo.New(PackageEventType.CostChanged, ev.PackageId, ev.OldVersion, ev.NewVersion, ev.NewPrice);
            return Task.CompletedTask;
        }
    }

    public class PackageEventType
    {
        public static object CostChanged { get; set; }
    }

    internal interface IPackageEventRepository
    {
        void New(object costChanged, object packageId, object oldVersion, object newVersion, object newPrice);
    }
}
