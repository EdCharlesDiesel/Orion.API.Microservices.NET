using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Postgres.Entities
{
    public class StateProvince
    {
        [Key]
        public int StateProvinceId { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public bool? IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public int TerritoryId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public CountryRegion CountryRegionCodeNavigation { get; set; }
        public SalesTerritory Territory { get; set; }
        public ICollection<Address> Address { get; set; } = new HashSet<Address>();
        public ICollection<SalesTaxRate> SalesTaxRate { get; set; } = new HashSet<SalesTaxRate>();
    }
}
