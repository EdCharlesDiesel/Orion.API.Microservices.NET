using Orion.API.Catalog.Services;
namespace Orion.API.Order.API.Services;

public interface IOrderServices:IRepository<Core.Order.Domain.Order>
{
    Task <List<Core.Order.Domain.Order>> _task(List<Core.Order.Domain.Order> entity);

}