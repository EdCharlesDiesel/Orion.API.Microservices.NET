using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class UnitMeasure
    {
        public string UnitMeasureCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<BillOfMaterials> BillOfMaterials { get; set; } = new HashSet<BillOfMaterials>();
        public ICollection<Product> ProductSizeUnitMeasureCodeNavigation { get; set; } = new HashSet<Product>();
        public ICollection<ProductVendor> ProductVendor { get; set; } = new HashSet<ProductVendor>();
        public ICollection<Product> ProductWeightUnitMeasureCodeNavigation { get; set; } = new HashSet<Product>();
    }
}
