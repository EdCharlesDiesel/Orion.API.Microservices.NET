using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductModelProductDescriptionCulture")]
    [Description("Cross-reference table mapping product descriptions and the language the description is written in.")]
    public class ProductModelProductDescriptionCulture
    {
        [Key]
        [Column(name:"ProductModelID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Product Model ID is required")]
        [Display(Name = "Product Model ID")]
        [Description("Primary key. Foreign key to ProductModel.ProductModelID.")]
        public int? ProductModelId { get; set; } // int
        // [Key]
        [Column(name:"ProductDescriptionID", TypeName = "int", Order = 2)]
        [Required(ErrorMessage = "Product Description ID is required")]
        [Display(Name = "Product Description ID")]
        [Description("Primary key. Foreign key to ProductDescription.ProductDescriptionID.")]
        public int? ProductDescriptionId { get; set; } // int
        // [Key]
        [Column(name:"CultureID", TypeName = "nchar", Order = 3)]
        [MaxLength(6)]
        [StringLength(6)]
        [Required(ErrorMessage = "Culture ID is required")]
        [Display(Name = "Culture ID")]
        [Description("Culture identification number. Foreign key to Culture.CultureID.")]
        public string CultureId { get; set; } // nchar(6)
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.ProductModelProductDescriptionCulture.ProductModelID -> Production.ProductModel.ProductModelID (FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID)
        public ProductModel ProductModel { get; set; }
        // Production.ProductModelProductDescriptionCulture.ProductDescriptionID -> Production.ProductDescription.ProductDescriptionID (FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID)
        public ProductDescription ProductDescription { get; set; }
        // Production.ProductModelProductDescriptionCulture.CultureID -> Production.Culture.CultureID (FK_ProductModelProductDescriptionCulture_Culture_CultureID)
        public Culture Culture { get; set; }
    }
}
