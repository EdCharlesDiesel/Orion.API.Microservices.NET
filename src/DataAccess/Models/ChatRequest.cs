using System;

namespace Orion.DataAccess.Models;

public class ChatRequest
{
    public string? Message { get; set; } 
    public DateTime? LastUpdate { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? ReferenceDate { get; set; }
}