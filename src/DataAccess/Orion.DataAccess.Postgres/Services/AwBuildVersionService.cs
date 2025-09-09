using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.Tools;

namespace Orion.DataAccess.Postgres.Services;

public class AwBuildVersionService(IUnitOfWork unitOfWork)
{
    public void CreateAwBuildVersion(AWBuildVersion awBuildVersion)
    {
        unitOfWork.AWBuildVersions.AddAsync(awBuildVersion);
        unitOfWork.CompleteAsync();
    }
    
    public void GetAllAwBuildVersions()
    {
        unitOfWork.AWBuildVersions.GetAllAsync();
        unitOfWork.CompleteAsync();
    }
    
    public void GetByIdAwBuildVersion(int systemInformationId)
    {
        unitOfWork.AWBuildVersions.GetByIdAsync(systemInformationId);
        unitOfWork.CompleteAsync();
    }
    
    public void UpdateAwBuildVersion(AWBuildVersion awBuildVersion)
    {
        unitOfWork.AWBuildVersions.Update(awBuildVersion);
        unitOfWork.CompleteAsync();
    }
    
    public void GetUpdateAwBuildVersion(AWBuildVersion awBuildVersion)
    {
        unitOfWork.AWBuildVersions.Update(awBuildVersion);
        unitOfWork.CompleteAsync();
    }
}