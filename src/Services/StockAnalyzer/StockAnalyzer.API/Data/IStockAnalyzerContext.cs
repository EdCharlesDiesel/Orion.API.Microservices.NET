using Orion.StockAnalyzer.Core.Domain;

namespace Orion.Services.StockAnalyzer.API.Data
{
    public interface IStockAnalyzerContext
    {
        IEnumerable<LatestModel> LatestModels { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
