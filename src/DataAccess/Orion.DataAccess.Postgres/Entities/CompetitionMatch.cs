namespace Orion.DataAccess.Postgres.Entities
{
    public abstract class CompetitionMatch
    {
        private string? PlayerOne { get; set; }
        public string PlayerTwo { get; set; } = null!;
        public Guid LeagueCode { get; set; }
    }
}
