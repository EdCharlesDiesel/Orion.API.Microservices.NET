namespace Orion.DataAccess.Postgres.Entities
{
    public class CalendarDto
    {
        public Guid Id { get; set; }

        private string FirstName { get; set; } = string.Empty;

        private string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        public int YearsInService { get; set; }

        public decimal SuggestedBonus { get; set; }

        public decimal Salary { get; set; }

        public bool MinimumRaiseGiven { get; set; }

        public int JobLevel { get; set; }
    }
}
