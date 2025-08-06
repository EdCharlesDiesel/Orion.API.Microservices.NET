using Orion.API.Order.API.Data;
using Orion.API.Order.API.Services;


namespace Orion.API.Order.API.Repositories;

public class OrderRepository(OrderContext context) : IOrderServices
{
    public async Task<IEnumerable<Core.Order.Domain.Order>> GetAllAsync()
    {
        var orders =  context.Orders.ToList();
        if (orders == null || !orders.Any())
            throw new ArgumentException("orders be null or empty.");

        return orders.ToList();
    }
    public async Task<List<Core.Order.Domain.Order>> CreateOrders(List<Core.Order.Domain.Order> orders)
    {
        if (orders == null)
            throw new ArgumentException("order be null or empty.");

        await context.Orders.AddRangeAsync(orders);
        await context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return orders;
    }

    //TODO: Add comments
    public async Task<Core.Order.Domain.Order> Create(List<Core.Order.Domain.Order> orders)
    {
        if (orders == null || !orders.Any())
            throw new ArgumentException("order be null or empty.");

        await context.Orders.AddRangeAsync(orders);
        await context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return orders.First();
    }




    public async Task<Core.Order.Domain.Order?> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task<Core.Order.Domain.Order?> GetByIdAsync(Guid id)
    {
        var order =  context.Orders.FirstOrDefault(x => x.Id == id);
        if (order == null )
            throw new ArgumentException("order id cannot be null or empty.");

        return order;
    }

    public async Task AddAsync(Core.Order.Domain.Order order)
    {
        if (order == null)
            throw new ArgumentException("Order cannot be null or empty.");

        await context.Orders.AddAsync(order);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Core.Order.Domain.Order entity)
    {
        var order =  context.Orders.FirstOrDefault(x => x.Id == entity.Id);
        if (order == null)
            throw new ArgumentException("Order cannot be null or empty.");

        context.Orders.Update(order);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }

    async Task IOrderServices.CreateOrders(List<Core.Order.Domain.Order> entity)
    {
        await CreateOrders(entity);
    }

    public async Task DeleteAsync(Guid id)
    {
        var order =  context.Orders.FirstOrDefault(x => x.Id == id);
        if (order == null)
            throw new ArgumentException("Order cannot be null or empty.");

        context.Orders.Remove(order);
        await context.SaveChangesAsync();

    }

    public async Task<List<Core.Order.Domain.Order>> _task(List<Core.Order.Domain.Order> entity)
    {
        throw new NotImplementedException();
    }
}