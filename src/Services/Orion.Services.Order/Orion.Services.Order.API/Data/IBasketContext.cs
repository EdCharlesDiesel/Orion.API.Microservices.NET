using Microsoft.EntityFrameworkCore;

namespace Orion.Services.Basket.API.Data
{
    public interface IBasketContext
    {
        DbSet<Core.Basket.Domain.Basket> Baskets { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
