using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class CountryRegion
    {
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
        public ICollection<StateProvince> StateProvince { get; set; } = new HashSet<StateProvince>();
    }
}
