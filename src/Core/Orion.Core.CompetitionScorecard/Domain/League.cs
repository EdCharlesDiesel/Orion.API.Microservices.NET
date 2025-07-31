using System.ComponentModel.DataAnnotations;

namespace Orion.Core.CompetitionScorecard.Domain
{
    public class League
    {

        public Guid LeagueCode { get; set; }
        public string FramesToPlay { get; set; }
    }
}
