using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("HumanResources.Shift")]
    [Description("Work shift lookup table.")]
    public class Shift
    {
        public Shift()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }

        [Key]
        [Column(Name = "ShiftID", TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Shift ID is required")]
        [Display(Name = "Shift ID")]
        [Description("Primary key for Shift records.")]
        public byte? ShiftID { get; set; } // tinyint
        [Column(Name = "Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Shift description.")]
        public string Name { get; set; } // nvarchar(50)
        [Column(Name = "StartTime", TypeName = "time")]
        [Required(ErrorMessage = "Start Time is required")]
        [Display(Name = "Start Time")]
        [Description("Shift start time.")]
        public TimeSpan? StartTime { get; set; } // time(7)
        [Column(Name = "EndTime", TypeName = "time")]
        [Required(ErrorMessage = "End Time is required")]
        [Display(Name = "End Time")]
        [Description("Shift end time.")]
        public TimeSpan? EndTime { get; set; } // time(7)
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // HumanResources.EmployeeDepartmentHistory.ShiftID -> HumanResources.Shift.ShiftID (FK_EmployeeDepartmentHistory_Shift_ShiftID)
        public IEnumerable<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}
