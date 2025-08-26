using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Postgres.Entities
{
    public class TransactionHistory
    {
        [Key]
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int ReferenceOrderId { get; set; }
        public int ReferenceOrderLineId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public decimal ActualCost { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
