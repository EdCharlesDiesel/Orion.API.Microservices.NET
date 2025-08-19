using System;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Entities
{
    public class ProductListPriceHistory
    {
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
