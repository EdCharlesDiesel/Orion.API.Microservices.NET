namespace Orion.StockAnalyzer.Core.Domain
{
    public class Company
    {
        public string Symbol { get; set; } = null!;
        public string CompanyName { get; set; }= null!;
        public string Exchange { get; set; }= null!;
        public string Industry { get; set; }= null!;
        public string Website { get; set; }= null!;
        public string Description { get; set; }= null!;
        public string CEO { get; set; }= null!;
        public string IssueType { get; set; }= null!;
        public string Sector { get; set; }= null!;
    }
}
