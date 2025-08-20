namespace Orion.DataAccess.Postgres.Entities
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<ProductSubcategory> ProductSubcategory { get; set; } = new HashSet<ProductSubcategory>();
    }
}
