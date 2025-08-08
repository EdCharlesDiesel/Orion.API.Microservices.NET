using System;

namespace Orion.DataAccess.Models
{
    public class Matches
    {

        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public DateTimeOffset MatchDate { get; set; }
    }
}
