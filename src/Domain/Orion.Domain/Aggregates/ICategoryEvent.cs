using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public enum CategoryEventType {Deleted}
    public interface ICategoryEvent: IEntity<long>, IBaseEntity
    {
        CategoryEventType Type { get; }
        int CategoryId { get;}
        long? OldVersion { get;}
        long? NewVersion { get;}
    }

}
