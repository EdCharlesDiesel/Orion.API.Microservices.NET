namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VStoreWithDemographics
    {
        public int? BusinessEntityID { get; set; } // int
        public string Name { get; set; } // nvarchar(50)
        public decimal? AnnualSales { get; set; } // money
        public decimal? AnnualRevenue { get; set; } // money
        public string BankName { get; set; } // nvarchar(50)
        public string BusinessType { get; set; } // nvarchar(5)
        public int? YearOpened { get; set; } // int
        public string Specialty { get; set; } // nvarchar(50)
        public int? SquareFeet { get; set; } // int
        public string Brands { get; set; } // nvarchar(30)
        public string Internet { get; set; } // nvarchar(30)
        public int? NumberEmployees { get; set; } // int
    }
}
