using System.ComponentModel.DataAnnotations;

namespace Orion.Core.CompetitionScorecard.BaseClasses
{
    public abstract class Entity
    {
        [Key]
        [Required]
        public Guid Id  { get; set; }
        [Required]
        public DateTime CreatedDate  { get; set; }
        
        public DateTime ModifiedDate  { get; set; }
        [Required]
        public string CreateBy  { get; set; }
        public string ModifiedBy  { get; set; }
    }
}