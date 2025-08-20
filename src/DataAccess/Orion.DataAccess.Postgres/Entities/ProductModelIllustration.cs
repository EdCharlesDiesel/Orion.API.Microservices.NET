using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class ProductModelIllustration:Entity<Guid>
    {
        public int ProductModelId { get; set; }
        public int IllustrationId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Illustration Illustration { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
