using System;

namespace Orion.DataAccess.Entities
{
    public class SalesTerritoryHistory
    {
        public int SalesPersonId { get; set; }
        public int TerritoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SalesPerson SalesPerson { get; set; }
        public SalesTerritory Territory { get; set; }
    }
}
