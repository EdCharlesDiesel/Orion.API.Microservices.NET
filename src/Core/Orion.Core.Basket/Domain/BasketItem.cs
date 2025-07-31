using Orion.Core.Basket.BaseClasses;

namespace Orion.Core.Basket.Domain;

public class BasketItem: Entity
{
    public string? ProductName { get; set; }
    public int Quantity { get; set; } = 0;
    public decimal UnitPrice { get; set; }
    public decimal Total => UnitPrice * Quantity;
}