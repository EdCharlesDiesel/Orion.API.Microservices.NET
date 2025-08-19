using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orion.Domain.Aggregates;
using Orion.Domain.IRepositories;
using Orion.Domain.Tools;

namespace Orion.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        //private OrionDbContext context;
        //public CategoryRepository(OrionDbContext context)
        //{
        //    this.context = context;
        //}
        //public IUnitOfWork UnitOfWork => context;

        //public async Task<ICategory> Get(int id)
        //{
        //    return await context.Categories.Where(m => m.Id == id)
        //        .FirstOrDefaultAsync();
        //}

        //public object GetAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public object GetById(int id)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public ICategory New()
        //{
        //    var model = new Category();
        //    context.Categories.Add(model);
        //    return model;
        //}

        public async Task<IEnumerable<ICategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICategory> Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICategory New()
        {
            throw new NotImplementedException();
        }
    }
}
