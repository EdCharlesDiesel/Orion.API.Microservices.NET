using Orion.Core.Chat.Domain;

namespace Orion.Repository.Services.Orion;
public interface IChatRequestServices:IRepository<ChatRequest>
{
    Task<string> GetChatRequests();

}