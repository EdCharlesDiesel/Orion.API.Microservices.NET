using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Sales.SalesOrderHeader")]
    [Description("General sales order information.")]
    public class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            // this.SalesOrderDetails = new List<SalesOrderDetail>();
            // this.SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }

        [Key]
        [Column(name:"SalesOrderID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Sales Order ID is required")]
        [Display(Name = "Sales Order ID")]
        [Description("Primary key.")]
        public int? SalesOrderId { get; set; } // int
        [Column(name:"RevisionNumber", TypeName = "tinyint")]
        [Required(ErrorMessage = "Revision Number is required")]
        [Display(Name = "Revision Number")]
        [Description("Incremental number to track changes to the sales order over time.")]
        public byte? RevisionNumber { get; set; } // tinyint
        [Column(name:"OrderDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Order Date is required")]
        [Display(Name = "Order Date")]
        [Description("Dates the sales order was created.")]
        public DateTime? OrderDate { get; set; } // datetime
        [Column(name:"DueDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Due Date is required")]
        [Display(Name = "Due Date")]
        [Description("Date the order is due to the customer.")]
        public DateTime? DueDate { get; set; } // datetime
        [Column(name:"ShipDate", TypeName = "datetime")]
        [Display(Name = "Ship Date")]
        [Description("Date the order was shipped to the customer.")]
        public DateTime? ShipDate { get; set; } // datetime
        [Column(name:"Status", TypeName = "tinyint")]
        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        [Description("Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled")]
        public byte? Status { get; set; } // tinyint
        [Column(name:"OnlineOrderFlag", TypeName = "bit")]
        [Required(ErrorMessage = "Online Order Flag is required")]
        [Display(Name = "Online Order Flag")]
        [Description("0 = Order placed by sales person. 1 = Order placed online by customer.")]
        public bool? OnlineOrderFlag { get; set; } // bit
        [Column(name:"SalesOrderNumber", TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required(ErrorMessage = "Sales Order Number is required")]
        [Display(Name = "Sales Order Number")]
        [Description("Unique sales order identification number.")]
        public string SalesOrderNumber { get; set; } // nvarchar(25)
        [Column(name:"PurchaseOrderNumber", TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Purchase Order Number")]
        [Description("Customer purchase order number reference. ")]
        public string PurchaseOrderNumber { get; set; } // nvarchar(25)
        [Column(name:"AccountNumber", TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Account Number")]
        [Description("Financial accounting number reference.")]
        public string AccountNumber { get; set; } // nvarchar(15)
        [Column(name:"CustomerID", TypeName = "int")]
        [Required(ErrorMessage = "Customer ID is required")]
        [Display(Name = "Customer ID")]
        [Description("Customer identification number. Foreign key to Customer.BusinessEntityID.")]
        public int? CustomerId { get; set; } // int
        [Column(name:"SalesPersonID", TypeName = "int")]
        [Display(Name = "Sales Person ID")]
        [Description("Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.")]
        public int? SalesPersonId { get; set; } // int
        [Column(name:"TerritoryID", TypeName = "int")]
        [Display(Name = "Territory ID")]
        [Description("Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.")]
        public int? TerritoryId { get; set; } // int
        [Column(name:"BillToAddressID", TypeName = "int")]
        [Required(ErrorMessage = "Bill To Address ID is required")]
        [Display(Name = "Bill To Address ID")]
        [Description("Customer billing address. Foreign key to Address.AddressID.")]
        public int? BillToAddressId { get; set; } // int
        [Column(name:"ShipToAddressID", TypeName = "int")]
        [Required(ErrorMessage = "Ship To Address ID is required")]
        [Display(Name = "Ship To Address ID")]
        [Description("Customer shipping address. Foreign key to Address.AddressID.")]
        public int? ShipToAddressId { get; set; } // int
        [Column(name:"ShipMethodID", TypeName = "int")]
        [Required(ErrorMessage = "Ship Method ID is required")]
        [Display(Name = "Ship Method ID")]
        [Description("Shipping method. Foreign key to ShipMethod.ShipMethodID.")]
        public int? ShipMethodId { get; set; } // int
        [Column(name:"CreditCardID", TypeName = "int")]
        [Display(Name = "Credit Card ID")]
        [Description("Credit card identification number. Foreign key to CreditCard.CreditCardID.")]
        public int? CreditCardId { get; set; } // int
        [Column(name:"CreditCardApprovalCode", TypeName = "varchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Credit Card Approval Code")]
        [Description("Approval code provided by the credit card company.")]
        public string CreditCardApprovalCode { get; set; } // varchar(15)
        [Column(name:"CurrencyRateID", TypeName = "int")]
        [Display(Name = "Currency Rate ID")]
        [Description("Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.")]
        public int? CurrencyRateId { get; set; } // int
        [Column(name:"SubTotal", TypeName = "money")]
        [Required(ErrorMessage = "Sub Total is required")]
        [Display(Name = "Sub Total")]
        [Description("Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.")]
        public decimal? SubTotal { get; set; } // money
        [Column(name:"TaxAmt", TypeName = "money")]
        [Required(ErrorMessage = "Tax Amt is required")]
        [Display(Name = "Tax Amt")]
        [Description("Tax amount.")]
        public decimal? TaxAmt { get; set; } // money
        [Column(name:"Freight", TypeName = "money")]
        [Required(ErrorMessage = "Freight is required")]
        [Display(Name = "Freight")]
        [Description("Shipping cost.")]
        public decimal? Freight { get; set; } // money
        [Column(name:"TotalDue", TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required(ErrorMessage = "Total Due is required")]
        [Display(Name = "Total Due")]
        [Description("Total due from customer. Computed as Subtotal + TaxAmt + Freight.")]
        public decimal? TotalDue { get; set; } // money
        [Column(name:"Comment", TypeName = "nvarchar")]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Comment")]
        [Description("Sales representative comments.")]
        public string Comment { get; set; } // nvarchar(128)
        [Column(name:"rowguid", TypeName = "uniqueidentifier")]
        [Required(ErrorMessage = "rowguid is required")]
        [Display(Name = "rowguid")]
        [Description("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")]
        public Guid? Rowguid { get; set; } // uniqueidentifier
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Sales.SalesOrderHeader.CustomerID -> Sales.Customer.CustomerID (FK_SalesOrderHeader_Customer_CustomerID)
        public Customer Customer { get; set; }
        // Sales.SalesOrderHeader.SalesPersonID -> Sales.SalesPerson.BusinessEntityID (FK_SalesOrderHeader_SalesPerson_SalesPersonID)
        public SalesPerson SalesPerson { get; set; }
        // Sales.SalesOrderHeader.TerritoryID -> Sales.SalesTerritory.TerritoryID (FK_SalesOrderHeader_SalesTerritory_TerritoryID)
        public SalesTerritory SalesTerritory { get; set; }
        // Sales.SalesOrderHeader.BillToAddressID -> Person.Address.AddressID (FK_SalesOrderHeader_Address_BillToAddressID)
        public Address Address { get; set; }
        // Sales.SalesOrderHeader.ShipToAddressID -> Person.Address.AddressID (FK_SalesOrderHeader_Address_ShipToAddressID)
        public Address Address1 { get; set; }
        // Sales.SalesOrderHeader.ShipMethodID -> Purchasing.ShipMethod.ShipMethodID (FK_SalesOrderHeader_ShipMethod_ShipMethodID)
        public ShipMethod ShippedBy { get; set; }
        // Sales.SalesOrderHeader.CreditCardID -> Sales.CreditCard.CreditCardID (FK_SalesOrderHeader_CreditCard_CreditCardID)
        public CreditCard CreditCard { get; set; }
        // Sales.SalesOrderHeader.CurrencyRateID -> Sales.CurrencyRate.CurrencyRateID (FK_SalesOrderHeader_CurrencyRate_CurrencyRateID)
        public CurrencyRate CurrencyRate { get; set; }
        // Sales.SalesOrderDetail.SalesOrderID -> Sales.SalesOrderHeader.SalesOrderID (FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID)
        // public IEnumerable<SalesOrderDetail> SalesOrderDetails { get; set; }
        // Sales.SalesOrderHeaderSalesReason.SalesOrderID -> Sales.SalesOrderHeader.SalesOrderID (FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID)
        public IEnumerable<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
    }
}
