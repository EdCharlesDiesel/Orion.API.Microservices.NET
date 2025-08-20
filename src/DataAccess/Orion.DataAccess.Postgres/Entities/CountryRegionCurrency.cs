using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class CountryRegionCurrency:Entity<Guid>
    {
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }

        public CountryRegion CountryRegionCodeNavigation { get; set; }
        public Currency CurrencyCodeNavigation { get; set; }
    }
}
