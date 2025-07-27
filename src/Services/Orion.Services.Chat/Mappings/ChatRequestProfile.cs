using AutoMapper;
using Orion.Chat.Core.Domain;
using Orion.Services.Chat.DTO;

namespace Orion.Services.Chat.Mappings;

public class ChatRequestProfile : Profile
{
    public ChatRequestProfile()
    {
        CreateMap<ChatRequest, ChatRequestDto>().ReverseMap();
    }
}