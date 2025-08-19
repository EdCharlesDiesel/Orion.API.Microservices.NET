using System;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Entities
{
    public class ProductDocument
    {
        public int ProductId { get; set; }
        public int DocumentId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Document Document { get; set; }
        public Product Product { get; set; }
    }
}
