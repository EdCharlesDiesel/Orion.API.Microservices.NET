using Orion.StockAnalyzer.Core.BaseClasses;

namespace Orion.StockAnalyzer.Core.Domain;

public class LatestModel: Entity
{
    public string Country { get; set; }
    public string Category { get; set; }
    public string HistoricalDataSymbol { get; set; }
    public DateTime LastUpdate { get; set; }
}