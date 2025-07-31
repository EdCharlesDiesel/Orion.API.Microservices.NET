

using Orion.Core.Discount.BaseClasses;

namespace Orion.Core.Discount.Domain;
public class Coupon:Entity
{

    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
}