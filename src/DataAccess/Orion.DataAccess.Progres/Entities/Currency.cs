using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class Currency
    {
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
        public ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
        public ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
    }
}
