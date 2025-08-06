
using Orion.Core.Chat.Domain;

namespace Orion.Services.Intefaces;

public interface IChatRequestServices:IRepository<ChatRequest>
{
    Task<string> GetChatRequests();

}