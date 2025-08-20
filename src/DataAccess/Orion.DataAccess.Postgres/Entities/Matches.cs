namespace Orion.DataAccess.Postgres.Entities
{
    public class Matches
    {

        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public DateTimeOffset MatchDate { get; set; }
    }
}
