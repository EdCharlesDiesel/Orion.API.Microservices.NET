using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Sales.Customer")]
    [Description("Current customer information. Also see the Person and Store tables.")]
    public class Customer
    {
        public Customer()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        [Key]
        [Column(Name = "CustomerID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Customer ID is required")]
        [Display(Name = "Customer ID")]
        [Description("Primary key.")]
        public int? CustomerID { get; set; } // int
        [Column(Name = "PersonID", TypeName = "int")]
        [Display(Name = "Person ID")]
        [Description("Foreign key to Person.BusinessEntityID")]
        public int? PersonID { get; set; } // int
        [Column(Name = "StoreID", TypeName = "int")]
        [Display(Name = "Store ID")]
        [Description("Foreign key to Store.BusinessEntityID")]
        public int? StoreID { get; set; } // int
        [Column(Name = "TerritoryID", TypeName = "int")]
        [Display(Name = "Territory ID")]
        [Description("ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.")]
        public int? TerritoryID { get; set; } // int
        [Column(Name = "AccountNumber", TypeName = "varchar")]
        [MaxLength(10)]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required(ErrorMessage = "Account Number is required")]
        [Display(Name = "Account Number")]
        [Description("Unique number identifying the customer assigned by the accounting system.")]
        public string AccountNumber { get; set; } // varchar(10)
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

        // Sales.Customer.PersonID -> Person.Person.BusinessEntityID (FK_Customer_Person_PersonID)
        public Person Person { get; set; }
        // Sales.Customer.StoreID -> Sales.Store.BusinessEntityID (FK_Customer_Store_StoreID)
        public Store Store { get; set; }
        // Sales.Customer.TerritoryID -> Sales.SalesTerritory.TerritoryID (FK_Customer_SalesTerritory_TerritoryID)
        public SalesTerritory SalesTerritory { get; set; }
        // Sales.SalesOrderHeader.CustomerID -> Sales.Customer.CustomerID (FK_SalesOrderHeader_Customer_CustomerID)
        public IEnumerable<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
