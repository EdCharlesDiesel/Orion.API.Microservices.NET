using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.ScrapReason")]
    [Description("Manufacturing failure reasons lookup table.")]
    public class ScrapReason
    {
        public ScrapReason()
        {
            this.WorkOrders = new List<WorkOrder>();
        }

        [Key]
        [Column(name:"ScrapReasonID", TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Scrap Reason ID is required")]
        [Display(Name = "Scrap Reason ID")]
        [Description("Primary key for ScrapReason records.")]
        public short? ScrapReasonId { get; set; } // smallint
        [Column(name:"Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [Description("Failure description.")]
        public string Name { get; set; } // nvarchar(50)
        [Column(name:"ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.WorkOrder.ScrapReasonID -> Production.ScrapReason.ScrapReasonID (FK_WorkOrder_ScrapReason_ScrapReasonID)
        public IEnumerable<WorkOrder> WorkOrders { get; set; }
    }
}
