namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class UfnGetContactInformation
    {
        public int? PersonId { get; set; } // int
        public string FirstName { get; set; } // nvarchar(50)
        public string LastName { get; set; } // nvarchar(50)
        public string JobTitle { get; set; } // nvarchar(50)
        public string BusinessEntityType { get; set; } // nvarchar(50)
    }
}
