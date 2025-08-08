using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public enum OrderDetailEventType {Deleted}
    public interface IOrderDetailEvent: IEntity<long>, IBaseEntity
    {
        OrderDetailEventType Type { get; }
        int OrderDetailId { get;}
        long? OldVersion { get;}
        long? NewVersion { get;}
    }
}
