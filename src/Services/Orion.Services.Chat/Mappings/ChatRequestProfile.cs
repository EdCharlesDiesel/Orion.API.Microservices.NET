using AutoMapper;
using Orion.Core.Chat.Domain;
using Orion.Services.Chat.DTO;

namespace Orion.Services.Chat.Mappings;

public class ChatRequestProfile : Profile
{
    public ChatRequestProfile()
    {
        CreateMap<ChatRequest, ChatRequestDto>().ReverseMap();
    }
}