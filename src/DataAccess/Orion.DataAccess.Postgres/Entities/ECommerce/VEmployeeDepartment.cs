namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VEmployeeDepartment
    {
        public int? BusinessEntityID { get; set; } // int
        public string Title { get; set; } // nvarchar(8)
        public string FirstName { get; set; } // nvarchar(50)
        public string MiddleName { get; set; } // nvarchar(50)
        public string LastName { get; set; } // nvarchar(50)
        public string Suffix { get; set; } // nvarchar(10)
        public string JobTitle { get; set; } // nvarchar(50)
        public string Department { get; set; } // nvarchar(50)
        public string GroupName { get; set; } // nvarchar(50)
        public DateTime? StartDate { get; set; } // date
    }
}
