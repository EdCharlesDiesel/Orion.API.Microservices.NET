using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class ProductModelProductDescriptionCulture:Entity<Guid>
    {
        public int ProductModelId { get; set; }
        public int ProductDescriptionId { get; set; }
        public string CultureId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Culture Culture { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
