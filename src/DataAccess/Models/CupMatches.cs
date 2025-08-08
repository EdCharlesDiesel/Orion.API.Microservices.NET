using System;

namespace Orion.DataAccess.Models
{
    public class CupMatches
    {

        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public DateTimeOffset MatchDate { get; set; }
        public string Round { get; set; }
    }
}
