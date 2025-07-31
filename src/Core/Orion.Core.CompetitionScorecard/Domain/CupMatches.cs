using Orion.Core.CompetitionScorecard.BaseClasses;

namespace Orion.Core.CompetitionScorecard.Domain
{
    public class CupMatches: Entity
    {

        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public DateTimeOffset MatchDate { get; set; }
        public string Round { get; set; }
    }
}
