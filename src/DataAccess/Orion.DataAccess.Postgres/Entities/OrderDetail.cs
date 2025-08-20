using System.ComponentModel.DataAnnotations;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public abstract class OrderDetail(Product product, Order order):Entity<Guid>
    {

        [Required(ErrorMessage = "Unit Price is required")]
        public decimal UnitPrice { get; set; }


        [Required(ErrorMessage = "Quantity is required")]
        public short Quantity { get; set; }


        [Required(ErrorMessage = "Discount is required")]
        public Single Discount { get; set; }


        public Order Order { get; set; } = order;


        public Product Product { get; set; } = product;

        [ConcurrencyCheck]
        public long EntityVersion{ get; set; }


        [Required(ErrorMessage = "Order ID is required")]
        public int OrderId { get; set; }


        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

         private DateTime _createDate = DateTime.Now;
        
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;

        public Status Status { get => _status; set => _status = value; }
    
    }
}
