using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using System;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Models
{
    public class EmployeeTerritoryEvent :Entity<long>, IEmployeeTerritoryEvent
    {    

        public EmployeeTerritoryEventType Type { get; set; }

        public int EmployeeTerritoryId { get; set; }

        public long? OldVersion { get; set; }

        public long? NewVersion { get; set; } 

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; }
    }
}
    
    

