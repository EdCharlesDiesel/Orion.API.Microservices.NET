using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class CustomerAddress:Entity<Guid>
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Address Address { get; set; }
        public AddressType AddressType { get; set; }
        public Customer Customer { get; set; }
    }
}
