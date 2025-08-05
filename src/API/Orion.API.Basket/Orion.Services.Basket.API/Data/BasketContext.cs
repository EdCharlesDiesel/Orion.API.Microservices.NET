using Microsoft.EntityFrameworkCore;
using Orion.Services.Basket.API.Data;

namespace Orion.Services.Basket.API.Data
{
    public class BasketContext : DbContext, IBasketContext
    {
        public BasketContext(DbContextOptions<BasketContext> options)
            : base(options) { }


        public DbSet<Core.Basket.Domain.Basket> Baskets { get; set; }
    }
}
