using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Postgres.Entities
{
    public class SalesOrderHeaderSalesReason
    {
        [Key]
        public int SalesOrderId { get; set; }
        public int SalesReasonId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SalesOrderHeader SalesOrder { get; set; }
        public SalesReason SalesReason { get; set; }
    }
}
