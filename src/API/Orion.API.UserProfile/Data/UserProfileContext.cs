using Microsoft.EntityFrameworkCore;
using Orion.API.UserProfile.API.Models;

namespace Orion.API.UserProfile.API.Data
{
    public class UserProfileContext : DbContext<UserProfileContext>, IUserProfileContext
    {
        public UserProfileContext(DbContextOptions<UserProfileContext> options)
            : base(options) { }

        public DbSet<OrionUserProfile.Domain.UserProfile> UserProfiles { get; set; }

        public async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
    
}
