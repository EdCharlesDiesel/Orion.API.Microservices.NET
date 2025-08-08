using Orion.Domain.Aggregates;
using Orion.Domain.IRepositories;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //private OrionDbContext context;
        //public EmployeeRepository(OrionDbContext context)
        //{
        //    this.context = context;
        //}
        //public IUnitOfWork UnitOfWork => context;

        //public async Task<IEmployee> Get(int id)
        //{
        //    throw new NotImplementedException();
        //    //return await context.Employees.Where(m => m.Id == id)
        //    //    .FirstOrDefaultAsync();
        //}

        //public async Task<IEmployee> Delete(int id)
        //{
        //    var model = await Get(id);
        //    if (model == null) return null;
        //    context.Employees.Remove(model as Employee);
        //    //model.AddDomainEvent(
        //    //    new EmployeeDeleteEvent(
        //    //        model.Id, (model as Employee).EntityVersion));
        //    return model;
        //}

        //public IEmployee New()
        //{
        //    throw new NotImplementedException();            
        //    //var model = new Employee() { EntityVersion = 1 };
        //    //context.Employees.Add(model);
        //    //return model;
        //}
        public IUnitOfWork UnitOfWork { get; }
        public Task<IEmployee> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEmployee New()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IEmployee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEmployee> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
