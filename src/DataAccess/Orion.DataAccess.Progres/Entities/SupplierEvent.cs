using System;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Entities
{
    public class SupplierEvent : Entity<long>, ISupplierEvent
    {
        public SupplierEventType Type { get; set; }

        public int SupplierId { get; set; }
        public long? OldVersion { get; set; }
        public long? NewVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        // TODO investigate

        // int IEntity<int>.Id;
    }
}
