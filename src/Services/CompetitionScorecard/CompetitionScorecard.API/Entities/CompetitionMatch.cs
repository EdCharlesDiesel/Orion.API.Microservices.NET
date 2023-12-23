using System.ComponentModel.DataAnnotations;

namespace CompetitionScorecard.API.Entities
{
    public class CompetitionMatch
    {
        [Key]
        public Guid Id { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public Guid LeagueCode { get; set; }
    }
}
