using Orion.Core.TradingEconomics.BaseClasses;

namespace Orion.Core.TradingEconomics.Domain
{
    public class StockPrice:Entity
    {
        public string Ticker  { get; set; }
        public DateTime TradeDate  { get; set; }
        public decimal? Open  { get; set; }
        public decimal? High  { get; set; }
        public decimal? Low  { get; set; }
        public decimal? Close  { get; set; }
        public int Volume  { get; set; }
        public decimal Change  { get; set; }
        public decimal ChangePercent { get; set; }
    }
}