#nullable enable
using System;
using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Entities
{
    public class Product
    {
        [Required]
        [MaxLength(50)]
        public string? Code { get; set; } 

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; } 
        [MaxLength(550)]
        public string? Image { get; set; } 
        [MaxLength(50)]
        public string? Title { get; set; } 
        [Required]
        [MaxLength(50)]
        public decimal? Price { get; set; } 
        [MaxLength(50)]
        public int? Quantity { get; set; } 
        [MaxLength(50)]
        public DateTime? PublishedDate { get; set; } 
        [Required]
        [MaxLength(50)]
        public string? RetailPrice { get; set; } 
        [MaxLength(50)]
        public string? CoverFileName { get; set; } 
        [MaxLength(50)]
        public string? Category { get; set; } 
        [MaxLength(50)]
        public string? InventoryStatus { get; set; } 
        [MaxLength(50)]
        public string? Status { get; set; } 
        [MaxLength(50)]
        public string? Description { get; set; }

        public DateTime? StartValidityDate { get; set; }
    }
}
