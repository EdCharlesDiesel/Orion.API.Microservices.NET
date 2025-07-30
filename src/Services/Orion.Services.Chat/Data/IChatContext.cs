using Microsoft.EntityFrameworkCore;
using Orion.Core.Chat.Domain;


namespace Orion.Services.Chat.Data
{
    public interface IChatContext
    {
        DbSet<ChatRequest> ChatRequest { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
