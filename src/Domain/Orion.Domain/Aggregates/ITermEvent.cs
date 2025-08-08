using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public enum TermEventType {Deleted}
    public interface ITermEvent: IEntity<long>, IBaseEntity
    {
        TermEventType Type { get; }
        int TermId { get;}
        long? OldVersion { get;}
        long? NewVersion { get;}
    }
}
