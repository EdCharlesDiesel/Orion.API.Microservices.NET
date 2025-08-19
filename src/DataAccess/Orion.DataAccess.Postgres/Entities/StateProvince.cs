using System;
using System.Collections.Generic;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Entities
{
    public class StateProvince
    {
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
