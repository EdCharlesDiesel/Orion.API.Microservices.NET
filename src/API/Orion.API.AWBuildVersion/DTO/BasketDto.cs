using Orion.DataAccess.Postgres.Entities.Common;

namespace Orion.API.AWBuildVersion.DTO;

public class BasketDto
{
    public Guid UserId { get; set; } 
    public List<BasketItem>? Items { get; set; } 
    public decimal? TotalPrice { get; set; } 
    public string? Currency { get; set; } 
    public bool IsCheckedOut { get; set; } 
}