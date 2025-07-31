using System.ComponentModel.DataAnnotations;

namespace Orion.Services.CompetitionScorecard.API.Entities
{
    public class Player
    {       

        private string PlayerName;
        public string _PlayerName
        {
            get { return PlayerName; }
            set { PlayerName = this.FirstName + ' ' + this.LastName; }
        }

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }
        public Guid LeagueCode { get; set; }
    }
}
