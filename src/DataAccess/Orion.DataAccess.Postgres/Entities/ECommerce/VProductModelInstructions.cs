namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VProductModelInstructions
    {
        public int? ProductModelId { get; set; } // int
        public string Name { get; set; } // nvarchar(50)
        public string Instructions { get; set; } // nvarchar(max)
        public int? LocationId { get; set; } // int
        public decimal? SetupHours { get; set; } // decimal(9,4)
        public decimal? MachineHours { get; set; } // decimal(9,4)
        public decimal? LaborHours { get; set; } // decimal(9,4)
        public int? LotSize { get; set; } // int
        public string Step { get; set; } // nvarchar(1024)
        public Guid? Rowguid { get; set; } // uniqueidentifier
        public DateTime? ModifiedDate { get; set; } // datetime
    }
}
