using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class BusinessOwnerEvent(BusinessOwnerEventType type) : Entity<long>, IBusinessOwnerEvent
    {
        public BusinessOwnerEventType Type { get; set; } = type;
        public int BusinessOwnerId { get; set; }
        public decimal NewPrice { get; set; }
        public long? OldVersion { get; set; }
        public long? NewVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
    }

    public interface IBusinessOwnerEvent
    {
    }

    public class BusinessOwnerEventType
    {
    }
}
