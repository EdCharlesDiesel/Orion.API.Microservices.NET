using Microsoft.EntityFrameworkCore;
using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Services.StockAnalyzer.API.Data
{
    public interface IStockAnalyzerContext
    {
        DbSet<CalendarEvent> CalendarEvents { get; set; }
        DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        DbSet<Forecast> Forecast  { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
