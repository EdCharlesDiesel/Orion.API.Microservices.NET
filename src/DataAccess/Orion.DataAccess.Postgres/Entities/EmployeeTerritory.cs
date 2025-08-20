using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class EmployeeTerritory : Entity<int>, IEmployeeTerritory
    {

        // FIXME Fix the constructor EmployeeTerritory
        // public EmployeeTerritory()
        // {
        //    public IEnumerable<Territory> Territories { get; set; } 
        //    public IEnumerable<Employee> Employees { get; set; }
        // }

        public void FullUpdate(IEmployeeTerritory o)
        {
            throw new NotImplementedException();
        }
        private DateTime _createDate = DateTime.Now;
        
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        
        public Status Status { get => _status; set => _status = value; }
    }
}
    
    

