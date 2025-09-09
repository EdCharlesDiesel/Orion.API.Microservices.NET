using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.Services;
using Orion.DataAccess.Postgres.Tools;

public class AwBuildVersionService : IAwBuildVersionService
{
    private readonly IUnitOfWork _unitOfWork;

    public AwBuildVersionService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAwBuildVersion(AWBuildVersion awBuildVersion)
    {
        await _unitOfWork.AWBuildVersions.AddAsync(awBuildVersion);
        await _unitOfWork.CompleteAsync();
    }

    public async Task<IEnumerable<AWBuildVersion>> GetAllAwBuildVersions()
    {
        return await _unitOfWork.AWBuildVersions.GetAllAsync();
    }

    public async Task<AWBuildVersion?> GetByIdAwBuildVersion(int systemInformationId)
    {
        return await _unitOfWork.AWBuildVersions.GetByIdAsync(systemInformationId);
    }

    public async Task UpdateAwBuildVersion(AWBuildVersion awBuildVersion)
    {
        _unitOfWork.AWBuildVersions.Update(awBuildVersion);
        await _unitOfWork.CompleteAsync();
    }

    public async Task<IEnumerable<AWBuildVersion>> GetAllAsync()
    {
        return await _unitOfWork.AWBuildVersions.GetAllAsync();
    }
}