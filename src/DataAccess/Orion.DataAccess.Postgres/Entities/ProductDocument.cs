using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class ProductDocument:Entity<Guid>
    {
        public int ProductId { get; set; }
        public int DocumentId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Document Document { get; set; }
        public Product Product { get; set; }
    }
}
