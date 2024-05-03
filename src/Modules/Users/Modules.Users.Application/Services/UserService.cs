using Modules.Users.Application.Interfaces;
using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Interfaces;

namespace Modules.Users.Application;

public class UserService : IUsersService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task<User> GetByIdAsync(string id)
    {
        return await _userRepository.GetByIdAsync(id);
    }
}