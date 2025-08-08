using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{

    public enum BusinessOwnerEventType {Deleted}
    public interface IBusinessOwnerEvent: IEntity<long>, IBaseEntity
    {
        BusinessOwnerEventType Type { get; }
        int BusinessOwnerId { get;}
        long? OldVersion { get;}
        long? NewVersion { get;}
    }
}