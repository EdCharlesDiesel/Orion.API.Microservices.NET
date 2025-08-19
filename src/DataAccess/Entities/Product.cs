using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool? MakeFlag { get; set; }
        public bool? FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int? ProductSubcategoryId { get; set; }
        public int? ProductModelId { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ProductModel ProductModel { get; set; }
        public ProductSubcategory ProductSubcategory { get; set; }
        public UnitMeasure SizeUnitMeasureCodeNavigation { get; set; }
        public UnitMeasure WeightUnitMeasureCodeNavigation { get; set; }
        public ICollection<BillOfMaterials> BillOfMaterialsComponent { get; set; } = new HashSet<BillOfMaterials>();
        public ICollection<BillOfMaterials> BillOfMaterialsProductAssembly { get; set; } = new HashSet<BillOfMaterials>();
        public ICollection<ProductCostHistory> ProductCostHistory { get; set; } = new HashSet<ProductCostHistory>();
        public ICollection<ProductDocument> ProductDocument { get; set; } = new HashSet<ProductDocument>();
        public ICollection<ProductInventory> ProductInventory { get; set; } = new HashSet<ProductInventory>();
        public ICollection<ProductListPriceHistory> ProductListPriceHistory { get; set; } = new HashSet<ProductListPriceHistory>();
        public ICollection<ProductProductPhoto> ProductProductPhoto { get; set; } = new HashSet<ProductProductPhoto>();
        public ICollection<ProductReview> ProductReview { get; set; } = new HashSet<ProductReview>();
        public ICollection<ProductVendor> ProductVendor { get; set; } = new HashSet<ProductVendor>();
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; } = new HashSet<PurchaseOrderDetail>();
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; } = new HashSet<ShoppingCartItem>();
        public ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; } = new HashSet<SpecialOfferProduct>();
        public ICollection<TransactionHistory> TransactionHistory { get; set; } = new HashSet<TransactionHistory>();
        public ICollection<WorkOrder> WorkOrder { get; set; } = new HashSet<WorkOrder>();
    }
}
