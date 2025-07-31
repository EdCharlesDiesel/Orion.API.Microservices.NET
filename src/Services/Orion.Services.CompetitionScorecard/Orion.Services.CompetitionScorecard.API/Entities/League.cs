using System.ComponentModel.DataAnnotations;

namespace Orion.Services.CompetitionScorecard.API.Entities
{
    public class League
    {
        [Key]
        public Guid LeagueCode { get; set; }
        public int Id { get; set; }

        public string FramesToPlay { get; set; }
    }
}
