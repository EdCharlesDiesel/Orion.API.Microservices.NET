using System;
using System.Collections.Generic;


namespace Orion.DataAccess.Entities
{
    public class SalesPerson
    {
        public int SalesPersonId { get; set; }
        public int? TerritoryId { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Employee SalesPersonNavigation { get; set; }
        public SalesTerritory Territory { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
        public ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; } = new HashSet<SalesPersonQuotaHistory>();
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; } = new HashSet<SalesTerritoryHistory>();
        public ICollection<Store> Store { get; set; } = new HashSet<Store>();
    }
}
