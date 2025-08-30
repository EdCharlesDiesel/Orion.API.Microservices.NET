namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VStateProvinceCountryRegion
    {
        public int? StateProvinceId { get; set; } // int
        public string StateProvinceCode { get; set; } // nchar(3)
        public bool? IsOnlyStateProvinceFlag { get; set; } // bit
        public string StateProvinceName { get; set; } // nvarchar(50)
        public int? TerritoryId { get; set; } // int
        public string CountryRegionCode { get; set; } // nvarchar(3)
        public string CountryRegionName { get; set; } // nvarchar(50)
    }
}
