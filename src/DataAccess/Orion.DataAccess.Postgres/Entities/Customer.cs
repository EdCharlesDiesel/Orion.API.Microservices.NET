namespace Orion.DataAccess.Postgres.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int? TerritoryId { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerType { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SalesTerritory Territory { get; set; }
        public Individual Individual { get; set; }
        public Store Store { get; set; }
        public ICollection<CustomerAddress> CustomerAddress { get; set; } = new HashSet<CustomerAddress>();
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
    }
}
