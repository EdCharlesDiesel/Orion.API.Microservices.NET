namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VSalesPerson
    {
        public int? BusinessEntityID { get; set; } // int
        public string Title { get; set; } // nvarchar(8)
        public string FirstName { get; set; } // nvarchar(50)
        public string MiddleName { get; set; } // nvarchar(50)
        public string LastName { get; set; } // nvarchar(50)
        public string Suffix { get; set; } // nvarchar(10)
        public string JobTitle { get; set; } // nvarchar(50)
        public string PhoneNumber { get; set; } // nvarchar(25)
        public string PhoneNumberType { get; set; } // nvarchar(50)
        public string EmailAddress { get; set; } // nvarchar(50)
        public int? EmailPromotion { get; set; } // int
        public string AddressLine1 { get; set; } // nvarchar(60)
        public string AddressLine2 { get; set; } // nvarchar(60)
        public string City { get; set; } // nvarchar(30)
        public string StateProvinceName { get; set; } // nvarchar(50)
        public string PostalCode { get; set; } // nvarchar(15)
        public string CountryRegionName { get; set; } // nvarchar(50)
        public string TerritoryName { get; set; } // nvarchar(50)
        public string TerritoryGroup { get; set; } // nvarchar(50)
        public decimal? SalesQuota { get; set; } // money
        public decimal? SalesYTD { get; set; } // money
        public decimal? SalesLastYear { get; set; } // money
    }
}
