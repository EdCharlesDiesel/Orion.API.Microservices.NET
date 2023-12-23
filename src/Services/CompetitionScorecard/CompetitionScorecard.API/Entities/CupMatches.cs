using System.ComponentModel.DataAnnotations;

namespace CompetitionScorecard.API.Entities
{
    public class CupMatches
    {
        [Key]
        public Guid Id { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public DateTimeOffset MatchDate { get; set; }
        public string Round { get; set; }
    }
}
