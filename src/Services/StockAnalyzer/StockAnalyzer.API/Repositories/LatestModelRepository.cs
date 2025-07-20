using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.Services;
using Orion.StockAnalyzer.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Orion.Services.StockAnalyzer.API.Repositories
{

    public class LatestModelRepository : ILatestModelRepository
    {
         private readonly StockAnalyzerContext _context;

        public LatestModelRepository(StockAnalyzerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<IEnumerable<LatestModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<LatestModel?> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(LatestModel entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(LatestModel entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LatestModel>> GetLatestModels()
        {
            throw new NotImplementedException();
        }

        public async Task<LatestModel> GetLatestModel(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LatestModel>> GetLatestModelByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LatestModel>> GetLatestModelByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public async Task CreateLatestModel(LatestModel LatestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateLatestModel(LatestModel LatestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteLatestModel(string id)
        {
            throw new NotImplementedException();
        }
    }
}

