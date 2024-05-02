using Modules.Users.Domain.Entities;

namespace Modules.Users.Domain.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetByIdAsync(string id);
    Task<string> AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(string id);
}
