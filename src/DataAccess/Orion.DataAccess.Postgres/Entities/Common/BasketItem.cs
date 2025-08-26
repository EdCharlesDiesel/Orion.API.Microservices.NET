#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities.Common;
/// <summary>
/// Current basket of the database. 
/// </summary>
[Table("BasketItem")]
public abstract class BasketItem(string? productName) : Entity<Guid>
{
    public string? ProductName { get; set; } = productName;
    private int Quantity { get; set; } = 0;
    public decimal UnitPrice { get; set; }
    public decimal Total => UnitPrice * Quantity;
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public Status Status { get; set; }
}