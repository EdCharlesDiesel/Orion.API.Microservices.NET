using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.WorkOrderRouting")]
    [Description("Work order details.")]
    public class WorkOrderRouting
    {
        [Key]
        [Column(Name = "WorkOrderID", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Work Order ID is required")]
        [Display(Name = "Work Order ID")]
        [Description("Primary key. Foreign key to WorkOrder.WorkOrderID.")]
        public int? WorkOrderID { get; set; } // int
        [Key]
        [Column(Name = "ProductID", TypeName = "int", Order = 2)]
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        [Description("Primary key. Foreign key to Product.ProductID.")]
        public int? ProductID { get; set; } // int
        [Key]
        [Column(Name = "OperationSequence", TypeName = "smallint", Order = 3)]
        [Required(ErrorMessage = "Operation Sequence is required")]
        [Display(Name = "Operation Sequence")]
        [Description("Primary key. Indicates the manufacturing process sequence.")]
        public short? OperationSequence { get; set; } // smallint
        [Column(Name = "LocationID", TypeName = "smallint")]
        [Required(ErrorMessage = "Location ID is required")]
        [Display(Name = "Location ID")]
        [Description("Manufacturing location where the part is processed. Foreign key to Location.LocationID.")]
        public short? LocationID { get; set; } // smallint
        [Column(Name = "ScheduledStartDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Scheduled Start Date is required")]
        [Display(Name = "Scheduled Start Date")]
        [Description("Planned manufacturing start date.")]
        public DateTime? ScheduledStartDate { get; set; } // datetime
        [Column(Name = "ScheduledEndDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Scheduled End Date is required")]
        [Display(Name = "Scheduled End Date")]
        [Description("Planned manufacturing end date.")]
        public DateTime? ScheduledEndDate { get; set; } // datetime
        [Column(Name = "ActualStartDate", TypeName = "datetime")]
        [Display(Name = "Actual Start Date")]
        [Description("Actual start date.")]
        public DateTime? ActualStartDate { get; set; } // datetime
        [Column(Name = "ActualEndDate", TypeName = "datetime")]
        [Display(Name = "Actual End Date")]
        [Description("Actual end date.")]
        public DateTime? ActualEndDate { get; set; } // datetime
        [Column(Name = "ActualResourceHrs", TypeName = "decimal")]
        [Display(Name = "Actual Resource Hrs")]
        [Description("Number of manufacturing hours used.")]
        public decimal? ActualResourceHrs { get; set; } // decimal(9,4)
        [Column(Name = "PlannedCost", TypeName = "money")]
        [Required(ErrorMessage = "Planned Cost is required")]
        [Display(Name = "Planned Cost")]
        [Description("Estimated manufacturing cost.")]
        public decimal? PlannedCost { get; set; } // money
        [Column(Name = "ActualCost", TypeName = "money")]
        [Display(Name = "Actual Cost")]
        [Description("Actual manufacturing cost.")]
        public decimal? ActualCost { get; set; } // money
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.WorkOrderRouting.WorkOrderID -> Production.WorkOrder.WorkOrderID (FK_WorkOrderRouting_WorkOrder_WorkOrderID)
        public WorkOrder WorkOrder { get; set; }
        // Production.WorkOrderRouting.LocationID -> Production.Location.LocationID (FK_WorkOrderRouting_Location_LocationID)
        public Location Location { get; set; }
    }
}
