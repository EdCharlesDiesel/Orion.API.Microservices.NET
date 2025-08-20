using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class ProductProductPhoto:Entity<Guid>
    {
        public int ProductId { get; set; }
        public int ProductPhotoId { get; set; }
        public bool Primary { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
        public ProductPhoto ProductPhoto { get; set; }
    }
}
