using Orion.DataAccess.Entities;

namespace Orion.DataAccess.Postgres.Entities
{
    public class AddressType
    {
        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<CustomerAddress> CustomerAddress { get; set; } = new HashSet<CustomerAddress>();
        public ICollection<VendorAddress> VendorAddress { get; set; } = new HashSet<VendorAddress>();
    }
}
