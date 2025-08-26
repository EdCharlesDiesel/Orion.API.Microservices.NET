using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductSubcategory")]
    [Description("Product subcategories. See ProductCategory table.")]
    public class ProductSubcategory
    {
        public ProductSubcategory()
        {
            this.Products = new List<Product>();
        }

        [Key]
        [Column(Name = "ProductSubcategoryID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Product Subcategory ID is required")]
        [Display(Name = "Product Subcategory ID")]
        [Description("Primary key for ProductSubcategory records.")]
        public int? ProductSubcategoryID { get; set; } // int
        [Column(Name = "ProductCategoryID", TypeName = "int")]
        [Required(ErrorMessage = "Product Category ID is required")]
        [Display(Name = "Product Category ID")]
        [Description("Product category identification number. Foreign key to ProductCategory.ProductCategoryID.")]
        public int? ProductCategoryID { get; set; } // int
        [Column(Name = "Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Subcategory description.")]
        public string Name { get; set; } // nvarchar(50)
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

        // Production.ProductSubcategory.ProductCategoryID -> Production.ProductCategory.ProductCategoryID (FK_ProductSubcategory_ProductCategory_ProductCategoryID)
        public ProductCategory ProductCategory { get; set; }
        // Production.Product.ProductSubcategoryID -> Production.ProductSubcategory.ProductSubcategoryID (FK_Product_ProductSubcategory_ProductSubcategoryID)
        public IEnumerable<Product> Products { get; set; }
    }
}
