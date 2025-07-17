using Microsoft.EntityFrameworkCore;
using Orion.StockAnalyzer.Core.Domain;


namespace Orion.Services.StockAnalyzer.API.Data
{
    public class StockAnalyzerContext : DbContext, IStockAnalyzerContext
    {
    

        public StockAnalyzerContext(DbContextOptions<StockAnalyzerContext> options)
            : base(options) { }
        
        public IEnumerable<LatestModel> LatestModels { get; set; }
    }
}
