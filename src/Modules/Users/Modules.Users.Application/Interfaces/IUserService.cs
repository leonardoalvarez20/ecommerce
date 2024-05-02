using Modules.Users.Domain.Entities;
namespace Modules.Users.Application.Interfaces;

public interface IUsersService
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetByIdAsync(string id);
}
