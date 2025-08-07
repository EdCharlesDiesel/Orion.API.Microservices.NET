
using Microsoft.EntityFrameworkCore;


namespace Orion.API.UserProfile.Data
{
    public class UserProfileDbContext(DbContextOptions<UserProfileDbContext> options) : DbContext(options), IUserProfileDbContext
    {
        public DbSet<Core.UserProfile.Domain.UserProfile> UserProfiles { get; set; }
        
        
    }

    // public class UserProfileDbContext : IdentityDbContext<ApplicationUser>, IUserProfileDbContext
    // {
    //     public UserProfileDbContext(DbContextOptions<UserProfileDbContext> options)
    //         : base(options)
    //     {
    //     }
    //
    //     public DbSet<OrionUserProfile.Domain.UserProfile> UserProfiles { get; set; }
    //
    //     public async Task SaveChangesAsync()
    //     {
    //         await base.SaveChangesAsync();
    //     }
    // }
}