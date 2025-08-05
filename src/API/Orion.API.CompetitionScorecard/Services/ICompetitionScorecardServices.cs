using Orion.Core.CompetitionScorecard.Domain;

namespace Orion.Services.CompetitionScorecard.API.Services;

public interface ICompetitionScorecardServices:IRepository<Coupon>
{
    Task<Coupon> BuildCreate(List<Coupon> coupons);
}