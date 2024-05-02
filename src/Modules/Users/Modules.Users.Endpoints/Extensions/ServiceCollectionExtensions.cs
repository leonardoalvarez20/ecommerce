using Modules.Users.Application;
using Modules.Users.Application.Interfaces;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Infrastructure.Repositories;
using Modules.Users.Infrastructure.Persistence;

namespace Modules.Users.Endpoints;

public static class ServiceCollectionExtensions
{
    public static WebApplicationBuilder AddUserModule(this WebApplicationBuilder builder){
        builder.Services.AddScoped(provider =>
        {
            var config = provider.GetRequiredService<IConfiguration>();
            string connectionString = config["ECOMMERCE_DATABASE_SETTINGS:CONNECTIONSTRING"] ?? "";
            var databaseName = config["ECOMMERCE_DATABASE_SETTINGS:DATABASE"] ?? "";
            return new MongoDBContext(connectionString, databaseName);
        });
        builder.Services.AddScoped<IUsersService, UserService>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        return builder;
    }
}
