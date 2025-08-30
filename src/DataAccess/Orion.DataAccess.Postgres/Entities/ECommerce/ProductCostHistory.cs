using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductCostHistory")]
    [Description("Changes in the cost of a product over time.")]
    public class ProductCostHistory
    {
        [Key]
        [Column(name:"ProductID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        [Description("Product identification number. Foreign key to Product.ProductID")]
        public int? ProductId { get; set; } // int
        // [Key]
        [Column(name:"StartDate", TypeName = "datetime", Order = 2)]
        [Required(ErrorMessage = "Start Date is required")]
        [Display(Name = "Start Date")]
        [Description("Product cost start date.")]
        public DateTime? StartDate { get; set; } // datetime
        [Column(name:"EndDate", TypeName = "datetime")]
        [Display(Name = "End Date")]
        [Description("Product cost end date.")]
        public DateTime? EndDate { get; set; } // datetime
        [Column(name:"StandardCost", TypeName = "money")]
        [Required(ErrorMessage = "Standard Cost is required")]
        [Display(Name = "Standard Cost")]
        [Description("Standard cost of the product.")]
        public decimal? StandardCost { get; set; } // money
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.ProductCostHistory.ProductID -> Production.Product.ProductID (FK_ProductCostHistory_Product_ProductID)
        public Product Product { get; set; }
    }
}
