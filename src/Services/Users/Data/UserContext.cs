using Microsoft.EntityFrameworkCore;
using Orion.Services.Users.Entities;

namespace Orion.Services.Users.Data
{
    public class UserContextDbContext(DbContextOptions<UserContextDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
