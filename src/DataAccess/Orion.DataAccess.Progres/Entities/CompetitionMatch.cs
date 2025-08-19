using System;

namespace Orion.DataAccess.Entities
{
    public class CompetitionMatch
    {
        private string? PlayerOne { get; set; }
        public string PlayerTwo { get; set; } = null!;
        public Guid LeagueCode { get; set; }
    }
}
