namespace Orion.DataAccess.Postgres.Entities
{
    public class Store(string name, string demographics, Customer customer, SalesPerson salesPerson)
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = name;
        public int? SalesPersonId { get; set; }
        public string Demographics { get; set; } = demographics;
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Customer Customer { get; set; } = customer;
        public SalesPerson SalesPerson { get; set; } = salesPerson;
        public ICollection<StoreContact> StoreContact { get; set; } = new HashSet<StoreContact>();
    }
}
