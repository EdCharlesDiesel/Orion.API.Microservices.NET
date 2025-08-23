using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Postgres.Data
{
    // Inherit from IdentityDbContext instead of DbContext
    public sealed class OrionDbContext 
        : IdentityDbContext<IdentityUser, IdentityRole, string>, IOrionDbContext
    {
        public OrionDbContext(DbContextOptions<OrionDbContext> options)
            : base(options)
        {
        }

        // Your DbSets
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<AwbuildVersion> AwbuildVersion { get; set; }
        public DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactCreditCard> ContactCreditCard { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<CountryRegion> CountryRegion { get; set; }
        public DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Culture> Culture { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<CurrencyRate> CurrencyRate { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<DatabaseLog> DatabaseLog { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public DbSet<ErrorLog> ErrorLog { get; set; }
        public DbSet<Illustration> Illustration { get; set; }
        public DbSet<Individual> Individual { get; set; }
        public DbSet<JobCandidate> JobCandidate { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public DbSet<ProductDescription> ProductDescription { get; set; }
        public DbSet<ProductDocument> ProductDocument { get; set; }
        public DbSet<ProductInventory> ProductInventory { get; set; }
        public DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public DbSet<ProductModel> ProductModel { get; set; }
        public DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public DbSet<ProductPhoto> ProductPhoto { get; set; }
        public DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public DbSet<ProductVendor> ProductVendor { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public DbSet<SalesPerson> SalesPerson { get; set; }
        public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public DbSet<SalesReason> SalesReason { get; set; }
        public DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public DbSet<SalesTerritory> SalesTerritory { get; set; }
        public DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public DbSet<ScrapReason> ScrapReason { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<ShipMethod> ShipMethod { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<SpecialOffer> SpecialOffer { get; set; }
        public DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public DbSet<StateProvince> StateProvince { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<StoreContact> StoreContact { get; set; }
        public DbSet<TransactionHistory> TransactionHistory { get; set; }
        public DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public DbSet<UnitMeasure> UnitMeasure { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<VendorAddress> VendorAddress { get; set; }
        public DbSet<VendorContact> VendorContact { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }
        public DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }

        // Custom entities
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<ComtradeCategories> ComtradeCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Forecast> Forecast { get; set; }
        public DbSet<ChatRequest> ChatRequests { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CompetitionMatch> CompetitionMatches { get; set; }
        public DbSet<AwbuildVersion> AwbuildVersions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Order> Orders { get; set; }
        public object Database { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Must call base to ensure Identity tables are configured
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SalesOrderHeader>()
                .HasOne(soh => soh.BillToAddress)
                .WithMany(a => a.SalesOrderHeaderBillToAddress)
                .HasForeignKey(soh => soh.BillToAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SalesOrderHeader>()
                .HasOne(soh => soh.ShipToAddress)
                .WithMany(a => a.SalesOrderHeaderShipToAddress)
                .HasForeignKey(soh => soh.ShipToAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BillOfMaterials>(entity =>
            {
                entity.HasOne(b => b.ProductAssembly)
                    .WithMany(p => p.BillOfMaterialsAssembly)
                    .HasForeignKey(b => b.ProductAssemblyId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Component)
                    .WithMany(p => p.BillOfMaterialsComponent)
                    .HasForeignKey(b => b.ComponentId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CurrencyRate>(entity =>
            {
                entity.HasOne(d => d.FromCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyRateFromCurrencyCodeNavigation)
                    .HasForeignKey(d => d.FromCurrencyCode)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ToCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyRateToCurrencyCodeNavigation)
                    .HasForeignKey(d => d.ToCurrencyCode)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.SizeUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductsSizeUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.SizeUnitMeasureCode)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.WeightUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductsWeightUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.WeightUnitMeasureCode)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SalesPerson>()
                .Property(sp => sp.BusinessEntityId)
                .HasConversion<int>();

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.SalesPerson)
                .WithOne(sp => sp.SalesPersonNavigation)
                .HasForeignKey<SalesPerson>(sp => sp.BusinessEntityId);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
