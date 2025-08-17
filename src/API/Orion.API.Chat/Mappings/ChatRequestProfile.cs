using AutoMapper;
using Orion.API.Chat.DTO;
using Orion.DataAccess.Entities;

namespace Orion.API.Chat.Mappings;

public class ChatRequestProfile : Profile
{
    public ChatRequestProfile()
    {
        CreateMap<ChatRequest, ChatRequestDto>().ReverseMap();
    }
}