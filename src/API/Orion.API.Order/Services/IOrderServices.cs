namespace Orion.Services.Order.API.Services;

public interface IOrderServices:IRepository<Core.Order.Domain.Order>
{
    Task CreateOrders(List<Core.Order.Domain.Order> entity); 
}