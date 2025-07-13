using Orion.Services.Users.Data;
using Orion.Services.Users.Entities;

namespace Orion.Services.Users.Repositories
{

    public class UserRepository : IUserRepository
    {
        private readonly IUserContext _context;
        
        public UserRepository(IUserContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}

