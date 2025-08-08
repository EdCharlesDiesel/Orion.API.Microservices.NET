using System;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Models
{
    public class CustomerCustomerDemoEvent: Entity<long>, ICustomerCustomerDemoEvent
    {
        public CustomerCustomerDemoEventType Type { get; set; }
        public int CustomerCustomerDemoId { get; set; }
        public long? OldVersion { get; set; }
        public long? NewVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        // FIXME Need to investigate
        //int IEntity<int>.Id;
    }          
}
