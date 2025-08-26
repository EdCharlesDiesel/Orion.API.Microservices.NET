namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    public class VProductAndDescription
    {
        public int? ProductID { get; set; } // int
        public string Name { get; set; } // nvarchar(50)
        public string ProductModel { get; set; } // nvarchar(50)
        public string CultureID { get; set; } // nchar(6)
        public string Description { get; set; } // nvarchar(400)
    }
}
