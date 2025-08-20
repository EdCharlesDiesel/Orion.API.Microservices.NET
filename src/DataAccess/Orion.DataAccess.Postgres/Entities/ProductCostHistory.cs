using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class ProductCostHistory:Entity<Guid>
    {
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal StandardCost { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
