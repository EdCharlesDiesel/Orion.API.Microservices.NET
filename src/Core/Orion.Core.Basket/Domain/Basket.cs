

using Orion.Core.Basket.BaseClasses;

namespace Orion.Core.Basket.Domain
{
    public class Basket: Entity
    {
        public Guid UserId { get; set; } 
        public List<BasketItem>? Items { get; set; } 
        public decimal? TotalPrice { get; set; } 
        public string? Currency { get; set; } 
        public bool IsCheckedOut { get; set; } 
        
    }
}
