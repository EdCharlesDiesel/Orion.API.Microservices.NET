using Orion.Core.Catalog.Domain;
using Orion.Core.Orders.BaseClasses;

namespace Orion.Core.Orders.Domain
{
    public class Order: Entity
    {
        public Guid UserId { get; set; } 
        public List<Product>? Product { get; set; } 
        public string? OrderNumber { get; set; } 
        public int? OrderId { get; set; } 
        public DateTime OrderDate { get; set; } 
    }
}
