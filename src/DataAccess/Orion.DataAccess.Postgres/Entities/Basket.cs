#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Postgres.Entities
{
    /// <summary>
    /// Current basket of the database. 
    /// </summary>
    [Table("BuildVersion")]
    public abstract class Basket:Entity<Guid>
    {
        public Guid UserId { get; set; } 
        public List<BasketItem>? Items { get; set; } 
        public decimal? TotalPrice { get; set; } 
        public string? Currency { get; set; } 
        public bool IsCheckedOut { get; set; }

    }
}
