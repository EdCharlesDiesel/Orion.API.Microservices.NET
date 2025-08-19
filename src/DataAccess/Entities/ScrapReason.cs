using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class ScrapReason
    {
        public short ScrapReasonId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<WorkOrder> WorkOrder { get; set; } = new HashSet<WorkOrder>();
    }
}
