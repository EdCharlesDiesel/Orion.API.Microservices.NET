namespace Orion.DataAccess.Models;

public class BasketItem
{
    public string? ProductName { get; set; }
    public int Quantity { get; set; } = 0;
    public decimal UnitPrice { get; set; }
    public decimal Total => UnitPrice * Quantity;
}