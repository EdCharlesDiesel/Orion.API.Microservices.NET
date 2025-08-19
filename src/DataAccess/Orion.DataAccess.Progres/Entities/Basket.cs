#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
using Orion.DataAccess.Entities;
using Orion.Domain.Aggregates;
using Orion.Domain.Enums;

namespace Orion.DataAccess.Progres.Entities
{
    /// <summary>
    /// Current basket of the database. 
    /// </summary>
    [Table("BuildVersion")]
    public abstract class Basket:IBaseEntity
    {
        public Guid UserId { get; set; } 
        public List<BasketItem>? Items { get; set; } 
        public decimal? TotalPrice { get; set; } 
        public string? Currency { get; set; } 
        public bool IsCheckedOut { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
    }
}
