using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class Individual:Entity<Guid>
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public string Demographics { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Contact Contact { get; set; }
        public Customer Customer { get; set; }
    }
}
