using System;

namespace Orion.DataAccess.Entities
{
    public class EmployeePayHistory
    {
        public int EmployeeId { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Employee Employee { get; set; }
    }
}
