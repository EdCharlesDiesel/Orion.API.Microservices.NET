#nullable enable
namespace Orion.DataAccess.Postgres.Entities;

public abstract class ChatRequest
{
    public string? Message { get; set; } 
    public DateTime? LastUpdate { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? ReferenceDate { get; set; }
}