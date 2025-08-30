namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VStoreWithContacts
    {
        public int? BusinessEntityId { get; set; } // int
        public string Name { get; set; } // nvarchar(50)
        public string ContactType { get; set; } // nvarchar(50)
        public string Title { get; set; } // nvarchar(8)
        public string FirstName { get; set; } // nvarchar(50)
        public string MiddleName { get; set; } // nvarchar(50)
        public string LastName { get; set; } // nvarchar(50)
        public string Suffix { get; set; } // nvarchar(10)
        public string PhoneNumber { get; set; } // nvarchar(25)
        public string PhoneNumberType { get; set; } // nvarchar(50)
        public string EmailAddress { get; set; } // nvarchar(50)
        public int? EmailPromotion { get; set; } // int
    }
}
