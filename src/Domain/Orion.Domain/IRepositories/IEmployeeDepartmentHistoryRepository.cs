namespace Orion.Domain.IRepositories
{
    public interface IEmployeeDepartmentHistoryRepository : IRepository<IEmployeeDepartmentHistoryRepository>
    {
      //  Task<IEmployeeDepartmentHistory> Get(int id);
        IEmployeeDepartmentHistoryRepository New();
    }
}
