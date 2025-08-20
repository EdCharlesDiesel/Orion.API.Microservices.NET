using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public abstract class ContactCreditCard:Entity<Guid>
    {
        public int ContactId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Contact Contact { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
