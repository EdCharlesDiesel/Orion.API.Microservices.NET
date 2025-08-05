using Microsoft.EntityFrameworkCore;

namespace Orion.Services.Order.API.Data
{
    public interface IOrderContext
    {
        DbSet<Core.Order.Domain.Order> Orders { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
