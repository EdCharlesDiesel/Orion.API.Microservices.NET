using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Entities;

namespace Orion.DataAccess.Data
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
        DbSet<AwbuildVersion> AwbuildVersions  { get; set; }
        
        // DbSet<Orion.Core.Orders.Domain.Order> Orders  { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
