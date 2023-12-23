namespace Orion.Services.StockAnalyzer.API.Models
{
    public class LatestModel
    {
        public string Country { get; set; }
        public string Category { get; set; }
        public string HistoricalDataSymbol { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
