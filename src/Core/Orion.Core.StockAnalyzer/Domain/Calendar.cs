using Orion.StockAnalyzer.Core.BaseClasses;

namespace Orion.StockAnalyzer.Core.Domain;

public class Calendar: Entity
{
    public required string EventName { get; set; }
    public DateTime Date { get; set; }
}