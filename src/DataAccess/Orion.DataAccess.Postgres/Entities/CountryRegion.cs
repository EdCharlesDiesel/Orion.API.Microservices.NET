using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class CountryRegion:Entity<Guid>
    {
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
        public ICollection<StateProvince> StateProvince { get; set; } = new HashSet<StateProvince>();
    }
}
