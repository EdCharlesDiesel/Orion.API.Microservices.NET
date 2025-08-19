using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<StoreContact> StoreContact { get; set; } = new HashSet<StoreContact>();
        public ICollection<VendorContact> VendorContact { get; set; } = new HashSet<VendorContact>();
    }
}
