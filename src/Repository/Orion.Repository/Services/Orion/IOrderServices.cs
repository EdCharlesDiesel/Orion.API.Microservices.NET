using Orion.Core.Orders.Domain;

namespace Orion.Repository.Services.Orion;

public interface IOrderServices:IRepository<Order>
{
    Task <List<Core.Orders.Domain.Order>> _task(List<Core.Orders.Domain.Order> entity);

    Task CreateOrders(List<Core.Orders.Domain.Order> entity);
}