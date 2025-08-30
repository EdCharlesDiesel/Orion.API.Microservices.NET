using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Sales.SpecialOffer")]
    [Description("Sale discounts lookup table.")]
    public class SpecialOffer
    {
        public SpecialOffer()
        {
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
        }

        [Key]
        [Column(name:"SpecialOfferID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Special Offer ID is required")]
        [Display(Name = "Special Offer ID")]
        [Description("Primary key for SpecialOffer records.")]
        public int? SpecialOfferId { get; set; } // int
        [Column(name:"Description", TypeName = "nvarchar")]
        [MaxLength(255)]
        [StringLength(255)]
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        [Description("Discount description.")]
        public string Description { get; set; } // nvarchar(255)
        [Column(name:"DiscountPct", TypeName = "smallmoney")]
        [Required(ErrorMessage = "Discount Pct is required")]
        [Display(Name = "Discount Pct")]
        [Description("Discount precentage.")]
        public decimal? DiscountPct { get; set; } // smallmoney
        [Column(name:"Type", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Type is required")]
        [Display(Name = "Type")]
        [Description("Discount type category.")]
        public string Type { get; set; } // nvarchar(50)
        [Column(name:"Category", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        [Description("Group the discount applies to such as Reseller or Customer.")]
        public string Category { get; set; } // nvarchar(50)
        [Column(name:"StartDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Start Date is required")]
        [Display(Name = "Start Date")]
        [Description("Discount start date.")]
        public DateTime? StartDate { get; set; } // datetime
        [Column(name:"EndDate", TypeName = "datetime")]
        [Required(ErrorMessage = "End Date is required")]
        [Display(Name = "End Date")]
        [Description("Discount end date.")]
        public DateTime? EndDate { get; set; } // datetime
        [Column(name:"MinQty", TypeName = "int")]
        [Required(ErrorMessage = "Min Qty is required")]
        [Display(Name = "Min Qty")]
        [Description("Minimum discount percent allowed.")]
        public int? MinQty { get; set; } // int
        [Column(name:"MaxQty", TypeName = "int")]
        [Display(Name = "Max Qty")]
        [Description("Maximum discount percent allowed.")]
        public int? MaxQty { get; set; } // int
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

        // Sales.SpecialOfferProduct.SpecialOfferID -> Sales.SpecialOffer.SpecialOfferID (FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID)
        public IEnumerable<SpecialOfferProduct> SpecialOfferProducts { get; set; }
    }
}
