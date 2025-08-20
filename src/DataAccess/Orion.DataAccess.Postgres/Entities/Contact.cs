using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    public class Contact:Entity<Guid>
    {
        public int ContactId { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string EmailAddress { get; set; }
        public int EmailPromotion { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string AdditionalContactInfo { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<ContactCreditCard> ContactCreditCard { get; set; } = new HashSet<ContactCreditCard>();
        public ICollection<Employee> Employee { get; set; } = new HashSet<Employee>();
        public ICollection<Individual> Individual { get; set; } = new HashSet<Individual>();
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
        public ICollection<StoreContact> StoreContact { get; set; } = new HashSet<StoreContact>();
        public ICollection<VendorContact> VendorContact { get; set; } = new HashSet<VendorContact>();
    }
}
