using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Person.ContactType")]
    [Description("Lookup table containing the types of business entity contacts.")]
    public class ContactType
    {
        public ContactType()
        {
            this.BusinessEntityContact = new List<BusinessEntityContact>();
        }

        [Key]
        [Column(name:"ContactTypeID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Contact Type ID is required")]
        [Display(Name = "Contact Type ID")]
        [Description("Primary key for ContactType records.")]
        public int? ContactTypeId { get; set; } // int
        [Column(name: "Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Contact type description.")]
        public string Name { get; set; } // nvarchar(50)
        [Column(name: "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Person.BusinessEntityContact.ContactTypeID -> Person.ContactType.ContactTypeID (FK_BusinessEntityContact_ContactType_ContactTypeID)
        public IEnumerable<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
