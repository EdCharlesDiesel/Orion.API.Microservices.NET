using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public abstract class CompetitionMatch:Entity<Guid>
    {
        private string? PlayerOne { get; set; }
        public string PlayerTwo { get; set; } = null!;
        public Guid LeagueCode { get; set; }
    }
}
