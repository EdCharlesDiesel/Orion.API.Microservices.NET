namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VProductModelCatalogDescription
    {
        public int? ProductModelID { get; set; } // int
        public string Name { get; set; } // nvarchar(50)
        public string Summary { get; set; } // nvarchar(max)
        public string Manufacturer { get; set; } // nvarchar(max)
        public string Copyright { get; set; } // nvarchar(30)
        public string ProductURL { get; set; } // nvarchar(256)
        public string WarrantyPeriod { get; set; } // nvarchar(256)
        public string WarrantyDescription { get; set; } // nvarchar(256)
        public string NoOfYears { get; set; } // nvarchar(256)
        public string MaintenanceDescription { get; set; } // nvarchar(256)
        public string Wheel { get; set; } // nvarchar(256)
        public string Saddle { get; set; } // nvarchar(256)
        public string Pedal { get; set; } // nvarchar(256)
        public string BikeFrame { get; set; } // nvarchar(max)
        public string Crankset { get; set; } // nvarchar(256)
        public string PictureAngle { get; set; } // nvarchar(256)
        public string PictureSize { get; set; } // nvarchar(256)
        public string ProductPhotoID { get; set; } // nvarchar(256)
        public string Material { get; set; } // nvarchar(256)
        public string Color { get; set; } // nvarchar(256)
        public string ProductLine { get; set; } // nvarchar(256)
        public string Style { get; set; } // nvarchar(256)
        public string RiderExperience { get; set; } // nvarchar(1024)
        public Guid? rowguid { get; set; } // uniqueidentifier
        public DateTime? ModifiedDate { get; set; } // datetime
    }
}
