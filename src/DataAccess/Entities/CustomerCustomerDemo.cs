using System;
using Orion.Domain.Aggregates;
using Orion.Domain.DTOs;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Entities
{
    public class CustomerCustomerDemo : Entity<int>, ICustomerCustomerDemo
    {
        public void FullUpdate(ICustomerCustomerDemoFullEditDto o)
        {
            if (IsTransient())
            {
                Id = o.Id;
                CustomerId = o.CustomerId;
            }           
        }

        public long EntityVersion { get; set; }

        public int CustomerId { get; set; }

        private DateTime _createDate = DateTime.Now;
        
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        
        public Status Status { get => _status; set => _status = value; }
    }
}

