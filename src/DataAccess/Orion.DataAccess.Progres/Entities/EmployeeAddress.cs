using System;

namespace Orion.DataAccess.Entities
{
    public class EmployeeAddress
    {
        public int EmployeeId { get; set; }
        public int AddressId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Address Address { get; set; }
        public Employee Employee { get; set; }
    }
}
