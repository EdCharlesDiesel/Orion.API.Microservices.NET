using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductModelIllustration")]
    [Description("Cross-reference table mapping product models and illustrations.")]
    public class ProductModelIllustration
    {
        [Key]
        [Column(name:"ProductModelID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Product Model ID is required")]
        [Display(Name = "Product Model ID")]
        [Description("Primary key. Foreign key to ProductModel.ProductModelID.")]
        public int? ProductModelID { get; set; } // int
        [Key]
        [Column(name:"IllustrationID", TypeName = "int", Order = 2)]
        [Required(ErrorMessage = "Illustration ID is required")]
        [Display(Name = "Illustration ID")]
        [Description("Primary key. Foreign key to Illustration.IllustrationID.")]
        public int? IllustrationID { get; set; } // int
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.ProductModelIllustration.ProductModelID -> Production.ProductModel.ProductModelID (FK_ProductModelIllustration_ProductModel_ProductModelID)
        public ProductModel ProductModel { get; set; }
        // Production.ProductModelIllustration.IllustrationID -> Production.Illustration.IllustrationID (FK_ProductModelIllustration_Illustration_IllustrationID)
        public Illustration Illustration { get; set; }
    }
}
