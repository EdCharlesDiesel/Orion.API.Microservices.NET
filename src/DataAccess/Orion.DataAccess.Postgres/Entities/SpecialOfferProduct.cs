using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Postgres.Entities
{
    public class SpecialOfferProduct
    {
        [Key]
        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
        public SpecialOffer SpecialOffer { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetail { get; set; } = new HashSet<SalesOrderDetail>();
    }
}
