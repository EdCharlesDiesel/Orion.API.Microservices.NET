using Microsoft.EntityFrameworkCore;

namespace Orion.API.UserProfile.Data
{
    public interface IUserProfileDbContext
    {
        DbSet<Domain.IRepositories.UserProfile> UserProfiles { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
