

using Orion.Core.Catalog.BaseClasses;

namespace Orion.Core.Catalog.Domain
{
    public class Product: Entity
    {
        public string? Code { get; set; } 
        public string? Name { get; set; } 
        public string? Image { get; set; } 
        public string? Title { get; set; } 
        public string? Price { get; set; } 
        public string? Quantity { get; set; } 
        public string? PublishedDate { get; set; } 
        public string? RetailPrice { get; set; } 
        public string? CoverFileName { get; set; } 
        public string? Category { get; set; } 
        public string? InventoryStatus { get; set; } 
        public string? Status { get; set; } 
        public string? Description { get; set; } 
    }
}
