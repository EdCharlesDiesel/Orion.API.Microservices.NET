using Microsoft.EntityFrameworkCore;

namespace Orion.API.Order.API.Data
{
    public interface IOrderContext
    {
        DbSet<Core.Order.Domain.Order> Orders { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
