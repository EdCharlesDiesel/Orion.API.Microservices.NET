using Microsoft.EntityFrameworkCore;

namespace Orion.API.UserProfile.API.Data
{
    public interface IUserProfileContext
    {
        DbSet<OrionUserProfile.Domain.UserProfile> UserProfiles { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
