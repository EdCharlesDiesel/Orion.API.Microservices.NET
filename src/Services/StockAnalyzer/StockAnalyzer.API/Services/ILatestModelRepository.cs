using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Services.StockAnalyzer.API.Services
{

    public interface ILatestModelRepository: IRepository<LatestModel>
    {
        Task<IEnumerable<LatestModel>> GetLatestModels();
        Task<LatestModel> GetLatestModel(string id);
        Task<IEnumerable<LatestModel>> GetLatestModelByName(string name);
        Task<IEnumerable<LatestModel>> GetLatestModelByCategory(string categoryName);
        Task CreateLatestModel(LatestModel LatestModel);
        Task<bool> UpdateLatestModel(LatestModel LatestModel);
        Task<bool> DeleteLatestModel(string id);
        
    }
}
