using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Person.BusinessEntity")]
    [Description("Source of the ID that connects vendors, customers, and employees with address and contact information.")]
    public class BusinessEntity
    {
        public BusinessEntity()
        {
            this.BusinessEntityAddress = new List<Entities.BusinessEntityAddress>();
            this.BusinessEntityContact = new List<Entities.BusinessEntityContact>();
        }

        [Key]
        [Column(Name = "BusinessEntityID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Business Entity ID is required")]
        [Display(Name = "Business Entity ID")]
        [Description("Primary key for all customers, vendors, and employees.")]
        public int? BusinessEntityID { get; set; } // int
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

        // Person.BusinessEntityAddress.BusinessEntityID -> Person.BusinessEntity.BusinessEntityID (FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID)
        public IEnumerable<Entities.BusinessEntityAddress> BusinessEntityAddress { get; set; }
        // Person.BusinessEntityContact.BusinessEntityID -> Person.BusinessEntity.BusinessEntityID (FK_BusinessEntityContact_BusinessEntity_BusinessEntityID)
        public IEnumerable<Entities.BusinessEntityContact> BusinessEntityContact { get; set; }
        // Person.Person.BusinessEntityID -> Person.BusinessEntity.BusinessEntityID (FK_Person_BusinessEntity_BusinessEntityID)
        public Person Person { get; set; }
        // Purchasing.Vendor.BusinessEntityID -> Person.BusinessEntity.BusinessEntityID (FK_Vendor_BusinessEntity_BusinessEntityID)
        public Vendor Vendor { get; set; }
        // Sales.Store.BusinessEntityID -> Person.BusinessEntity.BusinessEntityID (FK_Store_BusinessEntity_BusinessEntityID)
        public Store Store { get; set; }
    }
}
