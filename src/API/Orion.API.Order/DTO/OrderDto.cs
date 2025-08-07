namespace Orion.API.Order.DTO;

public class OrderDto
{
    public Guid UserId { get; set; } 

    public string? OrderNumber { get; set; } 
    public int? OrderId { get; set; } 
    public DateTime OrderDate { get; set; } 
}