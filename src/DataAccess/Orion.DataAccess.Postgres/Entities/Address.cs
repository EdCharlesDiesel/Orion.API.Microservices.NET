using Orion.DataAccess.Entities;

namespace Orion.DataAccess.Postgres.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public StateProvince StateProvince { get; set; }
        public ICollection<CustomerAddress> CustomerAddress { get; set; } = new HashSet<CustomerAddress>();
        public ICollection<EmployeeAddress> EmployeeAddress { get; set; } = new HashSet<EmployeeAddress>();
        public ICollection<SalesOrderHeader> SalesOrderHeaderBillToAddress { get; set; } = new HashSet<SalesOrderHeader>();
        public ICollection<SalesOrderHeader> SalesOrderHeaderShipToAddress { get; set; } = new HashSet<SalesOrderHeader>();
        public ICollection<VendorAddress> VendorAddress { get; set; } = new HashSet<VendorAddress>();
    }
}
