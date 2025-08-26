namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VJobCandidateEducation
    {
        public int? JobCandidateID { get; set; } // int
        public string Edu.Level { get; set; } // nvarchar(max)
        public DateTime? Edu.StartDate { get; set; } // datetime
        public DateTime? Edu.EndDate { get; set; } // datetime
        public string Edu.Degree { get; set; } // nvarchar(50)
        public string Edu.Major { get; set; } // nvarchar(50)
        public string Edu.Minor { get; set; } // nvarchar(50)
        public string Edu.GPA { get; set; } // nvarchar(5)
        public string Edu.GPAScale { get; set; } // nvarchar(5)
        public string Edu.School { get; set; } // nvarchar(100)
        public string Edu.Loc.CountryRegion { get; set; } // nvarchar(100)
        public string Edu.Loc.State { get; set; } // nvarchar(100)
        public string Edu.Loc.City { get; set; } // nvarchar(100)
    }
}
