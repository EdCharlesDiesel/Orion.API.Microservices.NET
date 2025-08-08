

namespace Orion.Domain.IRepositories;
public interface IChatRequestServices:IRepository<ChatRequest>
{
    Task<string> GetChatRequests();

}