using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class ScrapReason: Entity<Guid>
    {
        public short ScrapReasonId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<WorkOrder> WorkOrder { get; set; } = new HashSet<WorkOrder>();
    }
}
