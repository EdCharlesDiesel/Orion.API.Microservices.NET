using Orion.Core.CompetitionScorecard.Domain;

namespace Orion.Repository.Services.Orion;

public interface ICompetitionScorecardServices:IRepository<CompetitionMatch>
{
    Task<CompetitionMatch> BuildCreate(List<CompetitionMatch> coupons);
}