using System;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Entities
{
    public class CustomerDemographicEvent: Entity<long>, ICustomerDemographicEvent
    {
        public CustomerDemographicEvent Type { get; set; }
        public int CustomerDemographicId { get; set; }
        public long? OldVersion { get; set; }
        public long? NewVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

      //  public int CustomerDemographicId => throw new NotImplementedException();

        CustomerDemographicEventType ICustomerDemographicEvent.Type => throw new NotImplementedException();
    }
}
