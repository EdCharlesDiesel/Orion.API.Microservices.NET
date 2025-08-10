using System;
using System.Collections.Generic;
using Orion.Domain.Aggregates;
using Orion.Domain.IRepositories;
using System.Threading.Tasks;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrionDbContext context;
        public OrderRepository(OrionDbContext context)
        {
            this.context = context;
        }
        public IUnitOfWork UnitOfWork => context;

        public async Task<IOrder> Get(int id)
        {
            return await context.Orders.Where(m => m.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IOrder> Delete(int id)
        {
            var model = await Get(id);
            if (model == null) return null;
            context.Orders.Remove(model as Order);
            model.AddDomainEvent(
                new OrderDeleteEvent(
                    model.Id, (model as Order).EntityVersion));
            return model;
        }

        public IOrder New()
        {
            var model = new Order() { EntityVersion = 1 };
            context.Orders.Add(model);
            return model;
        }

        Task IOrderRepository.Delete(int orderId)
        {
            throw new System.NotImplementedException();
        }
        public IUnitOfWork UnitOfWork => throw new System.NotImplementedException();

        public Task Delete(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IOrder> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IOrder New()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<IOrder>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IOrder> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(IOrder entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(IOrder entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
