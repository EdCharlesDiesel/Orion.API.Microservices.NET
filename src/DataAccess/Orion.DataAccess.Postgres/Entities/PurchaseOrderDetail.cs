using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Postgres.Entities
{
    public class PurchaseOrderDetail
    {
        [Key]
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderDetailId { get; set; }
        public DateTime DueDate { get; set; }
        public short OrderQty { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal RejectedQty { get; set; }
        public decimal StockedQty { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
        public PurchaseOrderHeader PurchaseOrder { get; set; }
    }
}
