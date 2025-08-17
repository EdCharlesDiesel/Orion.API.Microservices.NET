using System;
using System.Collections.Generic;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Entities
{
    public class CustomerDemographic:Entity<int>, ICustomerDemographic
    {

        public void FullUpdate(ICustomerDemographic o)
        {
            if (IsTransient())
            {
                Id = o.Id;
            }
            CustomerDescrition = o.CustomerDescrition;
        }

        public string CustomerDescrition { get; set; }

        public ICollection<CustomerCustomerDemo> Customers { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        
        public Status Status { get => _status; set => _status = value; }
    }
}