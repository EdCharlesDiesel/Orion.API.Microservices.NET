namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VSalesPersonSalesByFiscalYears
    {
        public int? SalesPersonID { get; set; } // int
        public string FullName { get; set; } // nvarchar(152)
        public string JobTitle { get; set; } // nvarchar(50)
        public string SalesTerritory { get; set; } // nvarchar(50)
        public decimal? _2002 { get; set; } // money
        public decimal? _2003 { get; set; } // money
        public decimal? _2004 { get; set; } // money
    }
}
