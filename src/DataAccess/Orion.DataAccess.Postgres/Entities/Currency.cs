using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class Currency
    {
        public Guid Id { get; set; }  // PK
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
        // public ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
        // public ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
        public object? Code { get; set; }
    }
}
