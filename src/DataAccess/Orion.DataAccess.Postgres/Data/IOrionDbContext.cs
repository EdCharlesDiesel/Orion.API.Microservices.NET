

using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.Entities.Common;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Data
{
    public interface IOrionDbContext
    {
        DbSet<Address> Address { get; set; }
        DbSet<AddressType> AddressType { get; set; }
        DbSet<AWBuildVersion> AwbuildVersion { get; set; }
        DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        DbSet<Contact> Contact { get; set; }
        DbSet<ContactCreditCard> ContactCreditCard { get; set; }
        DbSet<ContactType> ContactType { get; set; }
        DbSet<CountryRegion> CountryRegion { get; set; }
        DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        DbSet<CreditCard> CreditCard { get; set; }
        DbSet<Culture> Culture { get; set; }
        DbSet<Currency> Currency { get; set; }
        DbSet<CurrencyRate> CurrencyRate { get; set; }
        DbSet<Customer> Customer { get; set; }
        DbSet<CustomerAddress> CustomerAddress { get; set; }
        DbSet<DatabaseLog> DatabaseLog { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<Document> Document { get; set; }
        DbSet<Employee> Employee { get; set; }
        DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        DbSet<ErrorLog> ErrorLog { get; set; }
        DbSet<Illustration> Illustration { get; set; }
        DbSet<Individual> Individual { get; set; }
        DbSet<JobCandidate> JobCandidate { get; set; }
        DbSet<Location> Location { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<ProductCategory> ProductCategory { get; set; }
        DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        DbSet<ProductDescription> ProductDescription { get; set; }
        DbSet<ProductDocument> ProductDocument { get; set; }
        DbSet<ProductInventory> ProductInventory { get; set; }
        DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        DbSet<ProductModel> ProductModel { get; set; }
        DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        DbSet<ProductPhoto> ProductPhoto { get; set; }
        DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        DbSet<ProductReview> ProductReview { get; set; }
        DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        DbSet<ProductVendor> ProductVendor { get; set; }
        DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        DbSet<SalesPerson> SalesPerson { get; set; }
        DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        DbSet<SalesReason> SalesReason { get; set; }
        DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        DbSet<SalesTerritory> SalesTerritory { get; set; }
        DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        DbSet<ScrapReason> ScrapReason { get; set; }
        DbSet<Shift> Shift { get; set; }
        DbSet<ShipMethod> ShipMethod { get; set; }
        DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        DbSet<SpecialOffer> SpecialOffer { get; set; }
        DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        DbSet<StateProvince> StateProvince { get; set; }
        DbSet<Store> Store { get; set; }
        DbSet<StoreContact> StoreContact { get; set; }
        DbSet<TransactionHistory> TransactionHistory { get; set; }
        DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        DbSet<UnitMeasure> UnitMeasure { get; set; }
        DbSet<Vendor> Vendor { get; set; }
        DbSet<VendorAddress> VendorAddress { get; set; }
        DbSet<VendorContact> VendorContact { get; set; }
        DbSet<WorkOrder> WorkOrder { get; set; }
        DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
        DbSet<CalendarEvent> CalendarEvents { get; set; }
        DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        DbSet<Basket> Baskets  { get; set; }
        DbSet<Product> Products  { get; set; }
        DbSet<Forecast> Forecast  { get; set; }
        DbSet<ChatRequest> ChatRequests  { get; set; }
        DbSet<Coupon> Coupons  { get; set; }
        DbSet<CompetitionMatch> CompetitionMatches  { get; set; }
   
        
        // DbSet<Orion.Core.Orders.Domain.Order> Orders  { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class ContactCreditCard: Entity<int>
    {
    }

    public class CustomerAddress: Entity<int>
    {
    }

    public class StoreContact: Entity<int>
    {
    }

    public class VendorContact: Entity<int>
    {
    }

    public class VendorAddress: Entity<int>
    {
    }

    public class Individual: Entity<int>
    {
    }

    public class Contact: Entity<int>
    {
    }
}
