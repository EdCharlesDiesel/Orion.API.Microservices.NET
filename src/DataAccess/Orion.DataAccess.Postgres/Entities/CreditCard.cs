using System;
using System.Collections.Generic;
using Orion.DataAccess.Postgres.Entities;


namespace Orion.DataAccess.Entities
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public byte ExpMonth { get; set; }
        public short ExpYear { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<ContactCreditCard> ContactCreditCard { get; set; } = new HashSet<ContactCreditCard>();
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
    }
}
