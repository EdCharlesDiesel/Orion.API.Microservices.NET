using Microsoft.EntityFrameworkCore;
using Orion.Core.CompetitionScorecard.Domain;

namespace Orion.API.CompetitionScorecard.Data
{
    public class CompetitionScorecardContext(DbContextOptions<CompetitionScorecardContext> options)
        : DbContext(options), ICompetitionScorecardContext
    {
        public DbSet<Coupon> Coupons { get; set; }
    }
}
