using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public enum MasterUserEventType {Deleted}
    public interface IMasterUserEvent: IEntity<long>, IBaseEntity
    {
        MasterUserEventType Type { get; }
        int MasterUserId { get;}
        long? OldVersion { get;}
        long? NewVersion { get;}
    }

    
}
