namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class UspGetBillOfMaterials
    {
        public int? ProductAssemblyID { get; set; } // int
        public int? ComponentID { get; set; } // int
        public string ComponentDesc { get; set; } // nvarchar(50)
        public decimal? TotalQuantity { get; set; } // decimal(38,2)
        public decimal? StandardCost { get; set; } // money
        public decimal? ListPrice { get; set; } // money
        public short? BOMLevel { get; set; } // smallint
        public int? RecursionLevel { get; set; } // int
    }
}
