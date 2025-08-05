using Microsoft.EntityFrameworkCore;


namespace Orion.Services.UserProfile.API.Data
{
    public class UserProfileContext : DbContext, IUserProfileContext
    {
        public UserProfileContext(DbContextOptions<UserProfileContext> options)
            : base(options) { }


        public DbSet<OrionUserProfile.Domain.UserProfile> UserProfiles { get; set; }
    }
}
