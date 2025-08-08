using System;

namespace Orion.DataAccess.Models
{
    public class CompetitionMatch
    {

        public string? PlayerOne { get; set; }
        public string PlayerTwo { get; set; } = null!;
        public Guid LeagueCode { get; set; }
    }
}
