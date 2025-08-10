using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Models;
using Orion.Domain.IRepositories;

namespace Orion.DataAccess.Repositories
{
    public class DiscountRepository(DbContext context) : IDiscountRepository
    {
        public async Task<Coupon> GetDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDiscountRepository.DeleteDiscount(string productName)
        {
            return DeleteDiscount(productName);
        }

        public Task<bool> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        Task<Coupon> IDiscountRepository.GetDiscount(string productName)
        {
            return GetDiscount(productName);
        }

        public Task<bool> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Coupon>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        async Task IRepository.GetByIdAsync(Guid id)
        {
            await GetByIdAsync(id);
        }

        public async Task AddAsync(Coupon entity)
        {
            throw new NotImplementedException();
        }

        async Task IRepository.GetAllAsync()
        {
            await GetAllAsync();
        }

        public async Task<Coupon?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Coupon entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Coupon entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Coupon entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
