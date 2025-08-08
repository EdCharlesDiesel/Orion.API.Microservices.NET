using Orion.Domain.Tools;

namespace Orion.Domain.Aggregates
{
    public enum EmployeeTerritoryEventType {Deleted}
    public interface IEmployeeTerritoryEvent: IEntity<long>, IBaseEntity
    {
        EmployeeTerritoryEventType Type { get; }
        int EmployeeTerritoryId { get;}
        long? OldVersion { get;}
        long? NewVersion { get;}
    }
}
