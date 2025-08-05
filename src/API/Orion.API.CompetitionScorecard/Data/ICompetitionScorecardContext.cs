using Microsoft.EntityFrameworkCore;
using Orion.Core.CompetitionScorecard.Domain;

namespace Orion.API.CompetitionScorecard.Data
{
    public interface ICompetitionScorecardContext
    {
        DbSet<Coupon> Coupons { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
