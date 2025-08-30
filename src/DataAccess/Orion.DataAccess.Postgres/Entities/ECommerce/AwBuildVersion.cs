using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("AWBuildVersion")]
    [Description("Current version number of the AdventureWorks 2016 sample database. ")]
    public class AwBuildVersion
    {
        [Key]
        [Column(name: "SystemInformationID", TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "System Information ID is required")]
        [Display(Name = "System Information ID")]
        [Description("Primary key for AWBuildVersion records.")]
        public byte? SystemInformationId { get; set; } // tinyint
        [Column(name: "Database Version", TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Required(ErrorMessage = "Database Version is required")]
        [Display(Name = "Database Version")]
        [Description("Version number of the database in 9.yy.mm.dd.00 format.")]
        public string DatabaseVersion { get; set; } // nvarchar(25)
        [Column(name: "VersionDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Version Date is required")]
        [Display(Name = "Version Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? VersionDate { get; set; } // datetime
        [Column(name: "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime
    }
}
