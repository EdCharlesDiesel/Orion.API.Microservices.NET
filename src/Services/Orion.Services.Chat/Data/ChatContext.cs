using Microsoft.EntityFrameworkCore;
using Orion.Chat.Core.Domain;


namespace Orion.Services.Chat.Data
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
