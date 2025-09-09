using Orion.DataAccess.Postgres.Entities;

namespace Orion.DataAccess.Postgres.Services;

public interface IAwBuildVersionService
{
    Task CreateAwBuildVersion(AWBuildVersion awBuildVersion);
    Task<IEnumerable<AWBuildVersion>> GetAllAwBuildVersions();
    Task<AWBuildVersion?> GetByIdAwBuildVersion(int systemInformationId);
    Task UpdateAwBuildVersion(AWBuildVersion awBuildVersion);
    Task<IEnumerable<AWBuildVersion>>  GetAllAsync();
}