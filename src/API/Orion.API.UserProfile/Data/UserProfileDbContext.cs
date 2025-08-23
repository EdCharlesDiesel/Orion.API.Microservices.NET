using Microsoft.EntityFrameworkCore;
using Orion.API.UserProfile.Models;

namespace Orion.API.UserProfile.Data
{

    public class UserProfileDbContext : IdentityDbContext<ApplicationUser>, IUserProfileDbContext
    {
        public UserProfileDbContext(DbContextOptions<UserProfileDbContext> options)
            : base(options)
        {
        }
    
        public DbSet<Domain.IRepositories.UserProfile> UserProfiles { get; set; }
    
        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}