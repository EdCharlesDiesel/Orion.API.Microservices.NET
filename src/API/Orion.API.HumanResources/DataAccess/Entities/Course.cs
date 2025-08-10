namespace Orion.API.HumanResources.DataAccess.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public bool IsNew { get; set; } = true;
        public string Title { get; set; }         
        public List<Calendar> EmployeesThatAttended { get; set; } 
            = new List<Calendar>();

        public Course(string title)
        {
            Title = title;
        }
    }
}
