using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ProductDocument")]
    [Description("Cross-reference table mapping products to related product documents.")]
    public class ProductDocument
    {
        [Key]
        [Column(Name = "ProductID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        [Description("Product identification number. Foreign key to Product.ProductID.")]
        public int? ProductID { get; set; } // int
        [Key]
        [Column(Name = "DocumentNode", TypeName = "hierarchyid", Order = 2)]
        [Required(ErrorMessage = "Document Node is required")]
        [Display(Name = "Document Node")]
        [Description("Document identification number. Foreign key to Document.DocumentNode.")]
        public SqlHierarchyId DocumentNode { get; set; } // hierarchyid
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.ProductDocument.ProductID -> Production.Product.ProductID (FK_ProductDocument_Product_ProductID)
        public Product Product { get; set; }
        // Production.ProductDocument.DocumentNode -> Production.Document.DocumentNode (FK_ProductDocument_Document_DocumentNode)
        public Document Document { get; set; }
    }
}
