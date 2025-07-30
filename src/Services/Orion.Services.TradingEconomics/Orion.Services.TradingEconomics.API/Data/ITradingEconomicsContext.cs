using Microsoft.EntityFrameworkCore;
using Orion.Core.TradingEconomics.Domain;

namespace Orion.Services.TradingEconomics.API.Data
{
    public interface ITradingEconomicsContext
    {
        DbSet<CalendarEvent> CalendarEvents { get; set; }
        DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        DbSet<Forecast> Forecast  { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
