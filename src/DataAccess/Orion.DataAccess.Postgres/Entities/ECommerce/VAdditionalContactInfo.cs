namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VAdditionalContactInfo
    {
        public int? BusinessEntityId { get; set; } // int
        public string FirstName { get; set; } // nvarchar(50)
        public string MiddleName { get; set; } // nvarchar(50)
        public string LastName { get; set; } // nvarchar(50)
        public string TelephoneNumber { get; set; } // nvarchar(50)
        public string TelephoneSpecialInstructions { get; set; } // nvarchar(max)
        public string Street { get; set; } // nvarchar(50)
        public string City { get; set; } // nvarchar(50)
        public string StateProvince { get; set; } // nvarchar(50)
        public string PostalCode { get; set; } // nvarchar(50)
        public string CountryRegion { get; set; } // nvarchar(50)
        public string HomeAddressSpecialInstructions { get; set; } // nvarchar(max)
        public string EMailAddress { get; set; } // nvarchar(128)
        public string EMailSpecialInstructions { get; set; } // nvarchar(max)
        public string EMailTelephoneNumber { get; set; } // nvarchar(50)
        public Guid? Rowguid { get; set; } // uniqueidentifier
        public DateTime? ModifiedDate { get; set; } // datetime
    }
}
