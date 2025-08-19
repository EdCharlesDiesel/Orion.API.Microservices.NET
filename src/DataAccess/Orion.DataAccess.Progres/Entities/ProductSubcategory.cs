using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class ProductSubcategory
    {
        public int ProductSubcategoryId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public ICollection<Product> Product { get; set; } = new HashSet<Product>();
    }
}
