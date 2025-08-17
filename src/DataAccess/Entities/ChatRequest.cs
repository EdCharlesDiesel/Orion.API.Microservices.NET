#nullable enable
using System;

namespace Orion.DataAccess.Entities;

public abstract class ChatRequest
{
    public string? Message { get; set; } 
    public DateTime? LastUpdate { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? ReferenceDate { get; set; }
}