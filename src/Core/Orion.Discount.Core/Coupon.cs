using Orion.Discount.Core.BaseClasses;

namespace Orion.Discount.Core;
public class Coupon:Entity
{

    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
}