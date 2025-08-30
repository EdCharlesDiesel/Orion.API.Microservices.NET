using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductProductPhoto")]
    [Description("Cross-reference table mapping products and product photos.")]
    public class ProductProductPhoto
    {
        [Key]
        [Column(name:"ProductID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        [Description("Product identification number. Foreign key to Product.ProductID.")]
        public int? ProductId { get; set; } // int
        // [Key]
        [Column(name:"ProductPhotoID", TypeName = "int", Order = 2)]
        [Required(ErrorMessage = "Product Photo ID is required")]
        [Display(Name = "Product Photo ID")]
        [Description("Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.")]
        public int? ProductPhotoId { get; set; } // int
        [Column(name:"Primary", TypeName = "bit")]
        [Required(ErrorMessage = "Primary is required")]
        [Display(Name = "Primary")]
        [Description("0 = Photo is not the principal image. 1 = Photo is the principal image.")]
        public bool? Primary { get; set; } // bit
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.ProductProductPhoto.ProductID -> Production.Product.ProductID (FK_ProductProductPhoto_Product_ProductID)
        public Product Product { get; set; }
        // Production.ProductProductPhoto.ProductPhotoID -> Production.ProductPhoto.ProductPhotoID (FK_ProductProductPhoto_ProductPhoto_ProductPhotoID)
        public ProductPhoto ProductPhoto { get; set; }
    }
}
