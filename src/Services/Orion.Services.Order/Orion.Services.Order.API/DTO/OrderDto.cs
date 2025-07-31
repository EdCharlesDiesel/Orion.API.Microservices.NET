using Orion.Core.Catalog.Domain;

namespace Orion.Services.Order.API.DTO;

public class OrderDto
{
    public Guid UserId { get; set; } 
    public List<Product>? Product { get; set; } 
    public string? OrderNumber { get; set; } 
    public int? OrderId { get; set; } 
    public DateTime OrderDate { get; set; } 
}