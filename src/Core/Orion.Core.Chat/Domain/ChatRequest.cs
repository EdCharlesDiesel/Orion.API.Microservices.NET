using Orion.Core.Chat.BaseClasses;

namespace Orion.Core.Chat.Domain;

public class ChatRequest: Entity
{
    public string? Message { get; set; } 
    public DateTime? LastUpdate { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? ReferenceDate { get; set; }
}