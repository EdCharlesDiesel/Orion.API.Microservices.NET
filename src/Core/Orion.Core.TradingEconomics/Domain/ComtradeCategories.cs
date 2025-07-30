using Orion.Core.TradingEconomics.BaseClasses;

namespace Orion.Core.TradingEconomics.Domain;

public class ComtradeCategories : EntityKeyless
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string ParentId { get; set; } = null!;
    public string PrettyName { get; set; } = null!;
}