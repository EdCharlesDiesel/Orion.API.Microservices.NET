namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VPersonDemographics
    {
        public int? BusinessEntityID { get; set; } // int
        public decimal? TotalPurchaseYTD { get; set; } // money
        public DateTime? DateFirstPurchase { get; set; } // datetime
        public DateTime? BirthDate { get; set; } // datetime
        public string MaritalStatus { get; set; } // nvarchar(1)
        public string YearlyIncome { get; set; } // nvarchar(30)
        public string Gender { get; set; } // nvarchar(1)
        public int? TotalChildren { get; set; } // int
        public int? NumberChildrenAtHome { get; set; } // int
        public string Education { get; set; } // nvarchar(30)
        public string Occupation { get; set; } // nvarchar(30)
        public bool? HomeOwnerFlag { get; set; } // bit
        public int? NumberCarsOwned { get; set; } // int
    }
}
