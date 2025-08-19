using System;
using System.Collections.Generic;


namespace Orion.DataAccess.Entities
{
    public class SalesTerritory
    {
        public int TerritoryId { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYtd { get; set; }
        public decimal CostLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Customer> Customer { get; set; } = new HashSet<Customer>();
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
        public ICollection<SalesPerson> SalesPerson { get; set; } = new HashSet<SalesPerson>();
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; } = new HashSet<SalesTerritoryHistory>();
        public ICollection<StateProvince> StateProvince { get; set; } = new HashSet<StateProvince>();
    }
}
