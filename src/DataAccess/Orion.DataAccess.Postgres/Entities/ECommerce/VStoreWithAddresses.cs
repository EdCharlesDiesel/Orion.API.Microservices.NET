namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VStoreWithAddresses
    {
        public int? BusinessEntityID { get; set; } // int
        public string Name { get; set; } // nvarchar(50)
        public string AddressType { get; set; } // nvarchar(50)
        public string AddressLine1 { get; set; } // nvarchar(60)
        public string AddressLine2 { get; set; } // nvarchar(60)
        public string City { get; set; } // nvarchar(30)
        public string StateProvinceName { get; set; } // nvarchar(50)
        public string PostalCode { get; set; } // nvarchar(15)
        public string CountryRegionName { get; set; } // nvarchar(50)
    }
}
