using Microsoft.EntityFrameworkCore;
using Orion.Core.Chat.Domain;

namespace Orion.API.Chat.Data
{
    public class ChatRequestContext : DbContext
    {
        public ChatRequestContext(DbContextOptions<ChatRequestContext> options)
            : base(options) { }
        

        public DbSet<ChatRequest> ChatRequests { get; set; }


        public async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
