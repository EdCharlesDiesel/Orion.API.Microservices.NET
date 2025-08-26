using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Person.AddressType")]
    [Description("Types of addresses stored in the Address table. ")]
    public class AddressType
    {
        public AddressType()
        {
            this.BusinessEntityAddress = new List<BusinessEntityAddress>();
        }

        [Key]
        [Column(name: "AddressTypeID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Address Type ID is required")]
        [Display(Name = "Address Type ID")]
        [Description("Primary key for AddressType records.")]
        public int? AddressTypeID { get; set; } // int
        [Column(name: "Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Address type description. For example, Billing, Home, or Shipping.")]
        public string Name { get; set; } // nvarchar(50)
        [Column(name: "rowguid", TypeName = "uniqueidentifier")]
        [Required(ErrorMessage = "rowguid is required")]
        [Display(Name = "rowguid")]
        [Description("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")]
        public Guid? rowguid { get; set; } // uniqueidentifier
        [Column(name:  "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Person.BusinessEntityAddress.AddressTypeID -> Person.AddressType.AddressTypeID (FK_BusinessEntityAddress_AddressType_AddressTypeID)
        public IEnumerable<BusinessEntityAddress> BusinessEntityAddress { get; set; }
    }
}
