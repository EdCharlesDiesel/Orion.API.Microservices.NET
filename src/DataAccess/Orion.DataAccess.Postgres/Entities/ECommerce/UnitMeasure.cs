using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.UnitMeasure")]
    [Description("Unit of measure lookup table.")]
    public class UnitMeasure
    {
        public UnitMeasure()
        {
            this.BillOfMaterials = new List<BillOfMaterials>();
            this.Products = new List<Product>();
            this.Products1 = new List<Product>();
            this.ProductVendors = new List<ProductVendor>();
        }

        [Key]
        [Column(Name = "UnitMeasureCode", TypeName = "nchar")]
        [MaxLength(3)]
        [StringLength(3)]
        [Required(ErrorMessage = "Unit Measure Code is required")]
        [Display(Name = "Unit Measure Code")]
        [Description("Primary key.")]
        public string UnitMeasureCode { get; set; } // nchar(3)
        [Column(Name = "Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Unit of measure description.")]
        public string Name { get; set; } // nvarchar(50)
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.BillOfMaterials.UnitMeasureCode -> Production.UnitMeasure.UnitMeasureCode (FK_BillOfMaterials_UnitMeasure_UnitMeasureCode)
        public IEnumerable<BillOfMaterials> BillOfMaterials { get; set; }
        // Production.Product.SizeUnitMeasureCode -> Production.UnitMeasure.UnitMeasureCode (FK_Product_UnitMeasure_SizeUnitMeasureCode)
        public IEnumerable<Product> Products { get; set; }
        // Production.Product.WeightUnitMeasureCode -> Production.UnitMeasure.UnitMeasureCode (FK_Product_UnitMeasure_WeightUnitMeasureCode)
        public IEnumerable<Product> Products1 { get; set; }
        // Purchasing.ProductVendor.UnitMeasureCode -> Production.UnitMeasure.UnitMeasureCode (FK_ProductVendor_UnitMeasure_UnitMeasureCode)
        public IEnumerable<ProductVendor> ProductVendors { get; set; }
    }
}
