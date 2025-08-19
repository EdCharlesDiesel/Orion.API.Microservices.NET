using System;
using System.Collections.Generic;


namespace Orion.DataAccess.Entities
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public byte CreditRating { get; set; }
        public bool? PreferredVendorStatus { get; set; }
        public bool? ActiveFlag { get; set; }
        public string PurchasingWebServiceUrl { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<ProductVendor> ProductVendor { get; set; } = new HashSet<ProductVendor>();
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new HashSet<PurchaseOrderHeader>();
        public ICollection<VendorAddress> VendorAddress { get; set; } = new HashSet<VendorAddress>();
        public ICollection<VendorContact> VendorContact { get; set; } = new HashSet<VendorContact>();
    }
}
