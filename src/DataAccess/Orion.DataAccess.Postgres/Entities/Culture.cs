using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class Culture:Entity<Guid>
    {
        public string CultureId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; } = new HashSet<ProductModelProductDescriptionCulture>();
    }
}
