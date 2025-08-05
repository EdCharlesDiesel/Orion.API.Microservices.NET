using Microsoft.EntityFrameworkCore;

namespace Orion.API.Order.API.Data
{
    public class OrderContext : DbContext, IOrderContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options) { }


      
        public DbSet<Core.Order.Domain.Order> Orders { get; set; }
    }
}
