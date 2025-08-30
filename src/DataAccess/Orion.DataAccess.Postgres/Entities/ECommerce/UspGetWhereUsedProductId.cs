namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class UspGetWhereUsedProductId
    {
        public int? ProductAssemblyId { get; set; } // int
        public int? ComponentId { get; set; } // int
        public string ComponentDesc { get; set; } // nvarchar(50)
        public decimal? TotalQuantity { get; set; } // decimal(38,2)
        public decimal? StandardCost { get; set; } // money
        public decimal? ListPrice { get; set; } // money
        public short? BomLevel { get; set; } // smallint
        public int? RecursionLevel { get; set; } // int
    }
}
