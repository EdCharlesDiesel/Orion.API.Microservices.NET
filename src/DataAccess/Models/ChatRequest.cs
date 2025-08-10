#nullable enable
using System;

namespace Orion.DataAccess.Models;

public abstract class ChatRequest
{
    public string? Message { get; set; } 
    public DateTime? LastUpdate { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? ReferenceDate { get; set; }
}