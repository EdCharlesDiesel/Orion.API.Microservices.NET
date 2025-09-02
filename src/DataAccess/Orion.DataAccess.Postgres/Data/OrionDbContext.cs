using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Types;
using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.Entities.Common;

namespace Orion.DataAccess.Postgres.Data
{
    // Inherit from IdentityDbContext instead of DbContext
    public sealed class OrionDbContext(
        DbContextOptions<OrionDbContext> options)
        : IdentityDbContext<IdentityUser, IdentityRole, string>(options), IOrionDbContext
    {
        // Your DbSets
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<AwBuildVersion> AwbuildVersion { get; set; }
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

        // Common Entities.
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<ComtradeCategories> ComtradeCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Forecast> Forecast { get; set; }
        public DbSet<ChatRequest> ChatRequests { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CompetitionMatch> CompetitionMatches { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<OrderDetail> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // 👈 keep Identity configuration

            modelBuilder.Entity<BusinessEntityAddress>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.AddressID });

            modelBuilder.Entity<BusinessEntityContact>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.PersonID, bea.ContactTypeID });

            modelBuilder.Entity<CountryRegionCurrency>()
                .HasKey(bea => new { bea.CurrencyCode, bea.CountryRegionCode });

            modelBuilder.Entity<EmailAddress>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.EmailAddressID });

            modelBuilder.Entity<EmployeeDepartmentHistory>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.DepartmentID, bea.StartDate });
            // ❌ removed duplicate with ShiftID

            modelBuilder.Entity<EmployeePayHistory>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.RateChangeDate });

            modelBuilder.Entity<PersonCreditCard>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.CreditCardID });

            modelBuilder.Entity<PersonPhone>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.PhoneNumber });

            modelBuilder.Entity<ProductCostHistory>()
                .HasKey(bea => new { bea.ProductID, bea.StartDate });

            modelBuilder.Entity<ProductDocument>()
                .HasKey(bea => new { bea.ProductID, bea.DocumentNode });

            modelBuilder.Entity<ProductInventory>()
                .HasKey(bea => new { bea.ProductID, bea.LocationID });

            modelBuilder.Entity<ProductListPriceHistory>()
                .HasKey(bea => new { bea.ProductID, bea.StartDate });

            modelBuilder.Entity<ProductModelIllustration>()
                .HasKey(bea => new { bea.ProductModelID, bea.IllustrationID });
            // ❌ removed duplicate

            modelBuilder.Entity<ProductModelProductDescriptionCulture>()
                .HasKey(bea => new { bea.ProductModelID, bea.ProductDescriptionID, bea.CultureID });
            // ❌ removed duplicate

            modelBuilder.Entity<ProductProductPhoto>()
                .HasKey(bea => new { bea.ProductID, bea.ProductPhotoID });

            modelBuilder.Entity<ProductVendor>()
                .HasKey(bea => new { bea.ProductID, bea.BusinessEntityID });

            modelBuilder.Entity<PurchaseOrderDetail>()
                .HasKey(bea => new { bea.ProductID, bea.PurchaseOrderDetailID });
            
            modelBuilder.Entity<SalesOrderDetail>()
                .HasKey(d => new { d.SalesOrderID, d.SalesOrderDetailID });

            modelBuilder.Entity<SalesOrderHeaderSalesReason>()
                .HasKey(bea => new { bea.SalesOrderID, bea.SalesReasonID });

            modelBuilder.Entity<SalesPersonQuotaHistory>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.QuotaDate });
            // ❌ removed duplicate

            modelBuilder.Entity<SalesTerritoryHistory>()
                .HasKey(bea => new { bea.BusinessEntityID, bea.TerritoryID });

            modelBuilder.Entity<SpecialOfferProduct>()
                .HasKey(sop => new { sop.SpecialOfferID, sop.ProductID });

            modelBuilder.Entity<SalesOrderDetail>()
                .HasOne(sod => sod.SpecialOfferProduct)
                .WithMany(sop => sop.SalesOrderDetails)
                .HasForeignKey(sod => new { sod.SpecialOfferID, sod.ProductID }); 
            // 👆 Needs both FKs, not just ProductID

            modelBuilder.Entity<WorkOrderRouting>()
                .HasKey(bea => new { bea.WorkOrderID, bea.ProductID });

            // ✅ Fix for PostgreSQL: store hierarchyid as string/text
            modelBuilder.Entity<ProductDocument>()
                .Property(p => p.DocumentNode)
                .HasConversion(
                    v => v.ToString(),
                    v => SqlHierarchyId.Parse(v)
                )
                .HasColumnType("text");
            
            modelBuilder.Entity<Person>()
                .ToTable("Person");

            modelBuilder.Entity<Store>()
                .ToTable("Store");

            modelBuilder.Entity<Vendor>()
                .ToTable("Vendor");

            modelBuilder.Entity<BusinessEntity>()
                .ToTable("BusinessEntity"); // 👈 only if it has a table
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}