using MongoDB.Driver;

using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Infrastructure.Persistence;
namespace Modules.Users.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
   private readonly IMongoCollection<User> _users;

    public UserRepository(MongoDBContext dBContext)
    {
        _users = dBContext.Users;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _users.Find(_ => true).ToListAsync();
    }

    public async Task<User> GetByIdAsync(string id)
    {
        return await _users.Find(User => User.Id == id).FirstOrDefaultAsync();
    }

    public async Task<string> AddAsync(User User)
    {
        await _users.InsertOneAsync(User);
        return User.Id;
    }

    public async Task UpdateAsync(User User)
    {
        await _users.ReplaceOneAsync(t => t.Id == User.Id, User);
    }

    public async Task DeleteAsync(string id)
    {
        await _users.DeleteOneAsync(User => User.Id == id);
    }
}
