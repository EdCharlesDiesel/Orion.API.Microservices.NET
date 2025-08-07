using Microsoft.EntityFrameworkCore;
using Orion.Core.Basket.Domain;
using Orion.Core.Catalog.Domain;
using Orion.Core.Chat.Domain;
using Orion.Core.CompetitionScorecard.Domain;
using Orion.Core.Discount.Domain;
using Orion.Core.TradingEconomics.Domain;

namespace Orion.Repository.Data
{
    public interface IOrionDbContext
    {
        DbSet<CalendarEvent> CalendarEvents { get; set; }
        DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        DbSet<Basket> Baskets  { get; set; }
        DbSet<Product> Products  { get; set; }
        DbSet<Forecast> Forecast  { get; set; }
        DbSet<ChatRequest> ChatRequests  { get; set; }
        DbSet<Coupon> Coupons  { get; set; }
        DbSet<CompetitionMatch> CompetitionMatches  { get; set; }
        // DbSet<Orion.Core.Orders.Domain.Order> Orders  { get; set; }
        
        
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
