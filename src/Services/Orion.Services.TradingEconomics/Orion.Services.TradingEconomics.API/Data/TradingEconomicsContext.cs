using Microsoft.EntityFrameworkCore;
using Orion.Core.TradingEconomics.Domain;


namespace Orion.Services.TradingEconomics.API.Data
{
    public class TradingEconomicsContext : DbContext, ITradingEconomicsContext
    {
        public TradingEconomicsContext(DbContextOptions<TradingEconomicsContext> options)
            : base(options) { }
        

        public DbSet<CalendarEvent> CalendarEvents  { get; set; }
        public DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        public DbSet<Forecast> Forecast  { get; set; }

    }
}
