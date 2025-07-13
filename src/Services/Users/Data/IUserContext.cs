

using Orion.Services.Users.Entities;

namespace Orion.Services.Users.Data
{
    public interface IUserContext
    {
        IEnumerable<User> Users { get; }
    }
}
