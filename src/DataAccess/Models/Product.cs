using System.ComponentModel.DataAnnotations;

namespace Orion.DataAccess.Models
{
    public class Product
    {
        [Required]
        public string? Code { get; set; } 
        [Required]
        public string? Name { get; set; } 
        public string? Image { get; set; } 
        public string? Title { get; set; } 
        [Required]
        public decimal? Price { get; set; } 
        public int? Quantity { get; set; } 
        public string? PublishedDate { get; set; } 
        [Required]
        public string? RetailPrice { get; set; } 
        public string? CoverFileName { get; set; } 
        public string? Category { get; set; } 
        public string? InventoryStatus { get; set; } 
        public string? Status { get; set; } 
        public string? Description { get; set; } 
    }
}
