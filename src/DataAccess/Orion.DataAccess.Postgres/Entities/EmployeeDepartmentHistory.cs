using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class EmployeeDepartmentHistory:Entity<Guid>
    {
        public int EmployeeId { get; set; }
        public short DepartmentId { get; set; }
        public byte ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Department Department { get; set; }
        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
    }
}
