using System;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Entities
{
    public class StoreContact
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Contact Contact { get; set; }
        public ContactType ContactType { get; set; }
        public Store Customer { get; set; }
    }
}
