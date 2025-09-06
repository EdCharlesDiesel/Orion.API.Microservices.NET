using System;
using System.Threading.Tasks;
using Orion.Domain.IRepositories;

namespace Orion.Domain.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IAwBuildVersionRepository AWBuildVersions { get; }
        Task<int> CompleteAsync();
    }
}