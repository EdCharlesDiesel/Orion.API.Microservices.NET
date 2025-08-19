using System;
using System.Collections.Generic;


namespace Orion.DataAccess.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string NationalIdnumber { get; set; }
        public int ContactId { get; set; }
        public string LoginId { get; set; }
        public int? ManagerId { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Contact Contact { get; set; }
        public Employee Manager { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public ICollection<EmployeeAddress> EmployeeAddress { get; set; } = new HashSet<EmployeeAddress>();
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
        public ICollection<EmployeePayHistory> EmployeePayHistory { get; set; } = new HashSet<EmployeePayHistory>();
        public ICollection<Employee> InverseManager { get; set; } = new HashSet<Employee>();
        public ICollection<JobCandidate> JobCandidate { get; set; } = new HashSet<JobCandidate>();
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new HashSet<PurchaseOrderHeader>();
    }
}
