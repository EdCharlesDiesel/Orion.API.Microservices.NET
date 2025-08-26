using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Person.EmailAddress")]
    [Description("Where to send a person email.")]
    public class EmailAddress
    {
        [Key]
        [Column(Name = "BusinessEntityID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Business Entity ID is required")]
        [Display(Name = "Business Entity ID")]
        [Description("Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID")]
        public int? BusinessEntityID { get; set; } // int
        [Key]
        [Column(Name = "EmailAddressID", TypeName = "int", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Email Address ID is required")]
        [Display(Name = "Email Address ID")]
        [Description("Primary key. ID of this email address.")]
        public int? EmailAddressID { get; set; } // int
        [Column(Name = "EmailAddress", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Email Address")]
        [Description("E-mail address for the person.")]
        public string EmailAddress { get; set; } // nvarchar(50)
        [Column(Name = "rowguid", TypeName = "uniqueidentifier")]
        [Required(ErrorMessage = "rowguid is required")]
        [Display(Name = "rowguid")]
        [Description("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")]
        public Guid? rowguid { get; set; } // uniqueidentifier
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Person.EmailAddress.BusinessEntityID -> Person.Person.BusinessEntityID (FK_EmailAddress_Person_BusinessEntityID)
        public Person Person { get; set; }
    }
}
