using Orion.DataAccess.Postgres.Entities;
using Orion.DataAccess.Postgres.Tools;

namespace Orion.DataAccess.Postgres.Services;

public class AwBuildVersionService(IUnitOfWork unitOfWork)
{
    public void AddAwBuildVersion(AWBuildVersion awBuildVersion)
    {
        unitOfWork.AWBuildVersions.AddAsync(awBuildVersion);
        
        unitOfWork.CompleteAsync();
    }
}