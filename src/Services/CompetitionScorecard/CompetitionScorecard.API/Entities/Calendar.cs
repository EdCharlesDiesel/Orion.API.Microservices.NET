using System.ComponentModel.DataAnnotations;

namespace Orion.Services.CompetitionScorecard.API.Entities
{
    public class Calendar
    {
        [Key]
        public Guid Id{ get; set; }
        [Required]
        public DateTimeOffset DayOfTheWeek { get; set; }
    }
}
