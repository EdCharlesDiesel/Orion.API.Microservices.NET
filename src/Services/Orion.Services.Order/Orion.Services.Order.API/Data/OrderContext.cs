using Microsoft.EntityFrameworkCore;

namespace Orion.Services.Order.API.Data
{
    public class OrderContext : DbContext, IOrderContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options) { }


      
        public DbSet<Core.Order.Domain.Order> Orders { get; set; }
    }
}
