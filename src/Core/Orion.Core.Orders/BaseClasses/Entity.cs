using System.ComponentModel.DataAnnotations;

namespace Orion.Core.Orders.BaseClasses
{
    public abstract class Entity
    {
        [Key]
        [Required]
        public Guid Id  { get; set; } = Guid.NewGuid();
        [Required]
        public DateTime CreatedDate  { get; set; } = DateTime.UtcNow;
        [Required]
        public string CreateBy  { get; set; } = "System";
        public DateTime ModifiedDate  { get; set; }
        public string ModifiedBy  { get; set; } ="System";
    }
}