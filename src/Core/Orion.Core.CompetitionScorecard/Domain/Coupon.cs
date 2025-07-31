

using Orion.Core.CompetitionScorecard.BaseClasses;

namespace Orion.Core.CompetitionScorecard.Domain;
public class Coupon:Entity
{

    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
}