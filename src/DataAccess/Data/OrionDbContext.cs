using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Entities;

namespace Orion.DataAccess.Data
{
    public class OrionDbContext(DbContextOptions<OrionDbContext> options) : DbContext(options), IOrionDbContext
    {
        public DbSet<CalendarEvent> CalendarEvents  { get; set; }
        public DbSet<ComtradeCategories> ComtradeCategories  { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Forecast> Forecast  { get; set; }
        public DbSet<ChatRequest> ChatRequests { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CompetitionMatch> CompetitionMatches { get; set; }
        public DbSet<AwbuildVersion> AwbuildVersions  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        #region Commented code might use it to seed dummy data.

        // seed the database with data
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Owner>().HasData(
        //        new Owner()
        //        {
        //            Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
        //            FirstName = "Quentin",
        //            LastName = "Tarantino"
        //        },
        //        new Owner()
        //        {
        //            Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
        //            FirstName = "Joel",
        //            LastName = "Coen"
        //        },
        //        new Owner()
        //        {
        //            Id = Guid.Parse("c19099ed-94db-44ba-885b-0ad7205d5e40"),
        //            FirstName = "Martin",
        //            LastName = "Scorsese"
        //        },
        //        new Owner()
        //        {
        //            Id = Guid.Parse("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"),
        //            FirstName = "David",
        //            LastName = "Fincher"
        //        },
        //        new Owner()
        //        {
        //            Id = Guid.Parse("937b1ba1-7969-4324-9ab5-afb0e4d875e6"),
        //            FirstName = "Bryan",
        //            LastName = "Singer"
        //        },
        //        new Owner()
        //        {
        //            Id = Guid.Parse("7a2fbc72-bb33-49de-bd23-c78fceb367fc"),
        //            FirstName = "James",
        //            LastName = "Cameron"
        //        });

           

        //    base.OnModelCreating(modelBuilder);
        //}

        #endregion

    }
}
