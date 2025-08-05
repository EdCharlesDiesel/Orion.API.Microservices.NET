

namespace Orion.Services.Catalog.API.DTO;

public class ProductDto
{
    public Guid UserId { get; set; } 
    public List<Core.Catalog.Domain.Product>? Product { get; set; } 
    public string? OrderNumber { get; set; } 
    public int? OrderId { get; set; } 
    public DateTime OrderDate { get; set; } 
}