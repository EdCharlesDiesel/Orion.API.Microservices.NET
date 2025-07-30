using Microsoft.EntityFrameworkCore;
using Orion.Core.TradingEconomics.Domain;


namespace Orion.Services.StockAnalyzer.API.Data
{
    public class StockAnalyzerContext : DbContext, IStockAnalyzerContext
    {
        public StockAnalyzerContext(DbContextOptions<StockAnalyzerContext> options)
            : base(options) { }
        

        public DbSet<CalendarEvent> CalendarEvents  { get; set; }
        public DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        public DbSet<Forecast> Forecast  { get; set; }

    }
}
