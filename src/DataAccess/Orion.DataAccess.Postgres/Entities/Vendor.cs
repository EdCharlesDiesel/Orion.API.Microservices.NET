namespace Orion.DataAccess.Postgres.Entities
{
    public class Vendor(
        int vendorId,
        string accountNumber,
        string name,
        byte creditRating,
        bool? preferredVendorStatus,
        bool? activeFlag,
        string purchasingWebServiceUrl,
        DateTime modifiedDate)
    {
        public int VendorId { get; set; } = vendorId;

        public string AccountNumber { get; set; } = accountNumber;

        public string Name { get; set; } = name;
        public byte CreditRating { get; set; } = creditRating;
        public bool? PreferredVendorStatus { get; set; } = preferredVendorStatus;
        public bool? ActiveFlag { get; set; } = activeFlag;
        public string PurchasingWebServiceUrl { get; set; } = purchasingWebServiceUrl;
        public DateTime ModifiedDate { get; set; } = modifiedDate;

        public ICollection<ProductVendor> ProductVendor { get; set; } = new HashSet<ProductVendor>();
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new HashSet<PurchaseOrderHeader>();
        public ICollection<VendorAddress> VendorAddress { get; set; } = new HashSet<VendorAddress>();
        public ICollection<VendorContact> VendorContact { get; set; } = new HashSet<VendorContact>();
    }
}
