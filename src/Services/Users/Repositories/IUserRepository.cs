using Orion.Services.Users.Entities;


namespace Orion.Services.Users.Repositories
{

    public interface IUserRepository: IRepository<User>
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(string id);
        Task<IEnumerable<User>> GetUserByName(string name);
        Task<IEnumerable<User>> GetUserByCategory(string categoryName);
        Task CreateUser(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(string id);
        
    }
}
