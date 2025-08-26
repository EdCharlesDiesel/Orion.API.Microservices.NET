using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class CupMatches:Entity<Guid>
    {

        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public DateTimeOffset MatchDate { get; set; }
        public string Round { get; set; }
    }
}
