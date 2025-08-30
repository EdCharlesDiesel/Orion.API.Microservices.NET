namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class UspGetEmployeeManagers
    {
        public int? RecursionLevel { get; set; } // int
        public int? BusinessEntityId { get; set; } // int
        public string FirstName { get; set; } // nvarchar(50)
        public string LastName { get; set; } // nvarchar(50)
        public string OrganizationNode { get; set; } // nvarchar(4000)
        public string ManagerFirstName { get; set; } // nvarchar(50)
        public string ManagerLastName { get; set; } // nvarchar(50)
    }
}
