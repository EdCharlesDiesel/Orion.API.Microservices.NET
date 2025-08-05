using AutoMapper;
using Orion.API.Chat.DTO;
using Orion.Core.Chat.Domain;

namespace Orion.API.Chat.Mappings;

public class ChatRequestProfile : Profile
{
    public ChatRequestProfile()
    {
        CreateMap<ChatRequest, ChatRequestDto>().ReverseMap();
    }
}