#nullable enable
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;

namespace Orion.DataAccess.Models;
/// <summary>
/// Current basket of the database. 
/// </summary>
[Table("BasketItem")]
public abstract class BasketItem:IBaseEntity
{
    public string? ProductName { get; set; }
    private int Quantity { get; set; } = 0;
    public decimal UnitPrice { get; set; }
    public decimal Total => UnitPrice * Quantity;
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public Status Status { get; set; }
}