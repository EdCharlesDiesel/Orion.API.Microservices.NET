using System.ComponentModel.DataAnnotations;
using Orion.Core.CompetitionScorecard.BaseClasses;

namespace Orion.Core.CompetitionScorecard.Domain
{
    public class CompetitionMatch: Entity
    {

        public string? PlayerOne { get; set; }
        public string PlayerTwo { get; set; } = null!;
        public Guid LeagueCode { get; set; }
    }
}
