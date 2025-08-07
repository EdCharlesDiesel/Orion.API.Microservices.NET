using Microsoft.EntityFrameworkCore;

namespace Orion.API.UserProfile.Data
{
    public interface IUserProfileDbContext
    {
        DbSet<Core.UserProfile.Domain.UserProfile> UserProfiles { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
