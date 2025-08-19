using System;

namespace Orion.DataAccess.Entities
{
    public class ContactCreditCard
    {
        public int ContactId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Contact Contact { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
