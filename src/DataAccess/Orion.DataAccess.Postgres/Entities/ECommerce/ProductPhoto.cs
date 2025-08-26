using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductPhoto")]
    [Description("Product images.")]
    public class ProductPhoto
    {
        public ProductPhoto()
        {
            this.ProductProductPhotos = new List<ProductProductPhoto>();
        }

        [Key]
        [Column(Name = "ProductPhotoID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Product Photo ID is required")]
        [Display(Name = "Product Photo ID")]
        [Description("Primary key for ProductPhoto records.")]
        public int? ProductPhotoID { get; set; } // int
        [Column(Name = "ThumbNailPhoto", TypeName = "varbinary")]
        [MaxLength]
        [Display(Name = "Thumb Nail Photo")]
        [Description("Small image of the product.")]
        public byte[] ThumbNailPhoto { get; set; } // varbinary(max)
        [Column(Name = "ThumbnailPhotoFileName", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Thumbnail Photo File Name")]
        [Description("Small image file name.")]
        public string ThumbnailPhotoFileName { get; set; } // nvarchar(50)
        [Column(Name = "LargePhoto", TypeName = "varbinary")]
        [MaxLength]
        [Display(Name = "Large Photo")]
        [Description("Large image of the product.")]
        public byte[] LargePhoto { get; set; } // varbinary(max)
        [Column(Name = "LargePhotoFileName", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Large Photo File Name")]
        [Description("Large image file name.")]
        public string LargePhotoFileName { get; set; } // nvarchar(50)
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.ProductProductPhoto.ProductPhotoID -> Production.ProductPhoto.ProductPhotoID (FK_ProductProductPhoto_ProductPhoto_ProductPhotoID)
        public IEnumerable<ProductProductPhoto> ProductProductPhotos { get; set; }
    }
}
